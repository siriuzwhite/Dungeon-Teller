using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace Dungeon_Teller
{
    class Helper
    {
        public static Bitmap bmpTank = Properties.Resources.role_tank_32x32;
        public static Bitmap bmpHeal = Properties.Resources.role_heal_32x32;
        public static Bitmap bmpDps = Properties.Resources.role_dps_32x32;

        public static Bitmap ConvertToGrayScale(Bitmap original)
        {
            //create a blank bitmap the same size as original
            Bitmap newBitmap = new Bitmap(original.Width, original.Height);

            //get a graphics object from the new image
            Graphics g = Graphics.FromImage(newBitmap);

            //create the grayscale ColorMatrix
            ColorMatrix colorMatrix = new ColorMatrix(
               new float[][] 
              {
                 new float[] {.3f, .3f, .3f, 0, 0},
                 new float[] {.59f, .59f, .59f, 0, 0},
                 new float[] {.11f, .11f, .11f, 0, 0},
                 new float[] {0, 0, 0, 1, 0},
                 new float[] {0, 0, 0, 0, 1}
              });

            //create some image attributes
            ImageAttributes attributes = new ImageAttributes();

            //set the color matrix attribute
            attributes.SetColorMatrix(colorMatrix);

            //draw the original image on the new image
            //using the grayscale color matrix
            g.DrawImage(original, new Rectangle(0, 0, original.Width, original.Height),
               0, 0, original.Width, original.Height, GraphicsUnit.Pixel, attributes);

            //dispose the Graphics object
            g.Dispose();
            return newBitmap;
        }

        public static string getFormatedTimeString(int seconds)
        {
            double minutes = seconds / 60;
            int secs = seconds % 60;
            int mins = (int)Math.Floor(minutes);

            string FormatedTimeString = mins + " min. " + secs + " sec.";

            return FormatedTimeString;
        }

        public static void setNotQueued(dtModule module)
        {
            module.lbl_Status.Text = "not queued";
            module.lbl_Status.ForeColor = System.Drawing.Color.Red;
            module.lbl_Wait.Text = "n/a";
            module.lbl_QueueTime.Text = "n/a";

            if (module.lbl_Tank != null)
            {
                module.lbl_Tank.Text = "n/a";
                module.lbl_Healer.Text = "n/a";
                module.lbl_Dps.Text = "n/a";
                module.pic_Tank.Image = Helper.ConvertToGrayScale(bmpTank);
                module.pic_Heal.Image = Helper.ConvertToGrayScale(bmpHeal);
                module.pic_Dps.Image = Helper.ConvertToGrayScale(bmpDps);
            }
        }


        public static void LfgRefresh(dtModule module, uint category)
        {
            var LfgQueue = QueueStats.getLfgQueueStats(category);
            var LfgDungeon = QueueStats.LfgDungeons[LfgQueue.LfgDungeonsId];

            if (LfgDungeon.DungeonName.Length > 40)
                module.lbl_Status.Text = LfgDungeon.DungeonName.Substring(0, 37) + "...";
            else
                module.lbl_Status.Text = LfgDungeon.DungeonName;

            if (LfgQueue.myWait != -1)
                module.lbl_Wait.Text = Helper.getFormatedTimeString(LfgQueue.myWait);
            else
                module.lbl_Wait.Text = "n/a";

            int queuedTime = (System.Environment.TickCount - LfgQueue.queuedTime) / 1000;
            module.lbl_QueueTime.Text = Helper.getFormatedTimeString(queuedTime);

            int tank = LfgDungeon.totalTanks - LfgQueue.tankNeeds;
            int healer = LfgDungeon.totalHealers - LfgQueue.healerNeeds;
            int dps = LfgDungeon.totalDPS - LfgQueue.dpsNeeds;

            module.pic_Tank.Image = (LfgQueue.tankNeeds == 0) ? bmpTank : Helper.ConvertToGrayScale(bmpTank);
            module.pic_Heal.Image = (LfgQueue.healerNeeds == 0) ? bmpHeal : Helper.ConvertToGrayScale(bmpHeal);
            module.pic_Dps.Image = (LfgQueue.dpsNeeds == 0) ? bmpDps : Helper.ConvertToGrayScale(bmpDps);

            module.lbl_Tank.Text = tank + " / " + LfgDungeon.totalTanks;
            module.lbl_Healer.Text = healer + " / " + LfgDungeon.totalHealers;
            module.lbl_Dps.Text = dps + " / " + LfgDungeon.totalDPS;
        }
    }
}
