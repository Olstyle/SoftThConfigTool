using System;
using System.Collections.Generic;
using System.Text;

namespace SoftTh_Config_Tool
{
    class Display
    {
        private int xCoord = 0;
        private int yCoord = 0;
        private int destXCoord = 0;
        private int destYCoord = 0;
        private int height = 0;
        private int destHeight = 0;
        private int width = 0;
        private int destWidth = 0;
        private int borderL = 0;
        private int borderA = 0;

        private int fpsLimit = 0;
        private bool use = true;
        private bool islocal = false;
        private bool noSync = false;
        private bool speed = false;
        private bool destLinked = true;
        private String transporMethod = "auto";
        

        public Display()
        {
        }

        public Display(Display original)
        {
            xCoord = original.getxCoord();
            yCoord = original.getyCoord();
            height = original.getHeight();
            width = original.getWidth();
            use = original.Use();
            islocal = original.getlocal();
            fpsLimit = original.getFpsLimit();
        }
        public void setSpeed(bool s)
        {
            speed = s;
        }
        public bool getSpeed()
        {
            return speed;
        }
        public int getBorderL()
        {
            return borderL;
        }
        public int getBorderA()
        {
            return borderA;
        }
        public int getxCoord()
        {
            return xCoord;
        }
        public int getyCoord()
        {
            return yCoord;
        }
        public int getxDest()
        {
            return destXCoord;
        }
        public int getyDest()
        {
            return destYCoord;
        }
        public int getHeight()
        {
            return height;
        }
        public int getWidth()
        {
            return width;
        }
        public int getDestHeight()
        {
            return destHeight;
        }
        public int getDestWidth()
        {
            return destWidth;
        }
        public int getFpsLimit()
        {
            return fpsLimit;
        }
        public bool Use()
        {
            return use;
        }

        public void setxCoord(int xCoord)
        {
            this.xCoord = xCoord;
        }
        public void setyCoord(int yCoord)
        {
            this.yCoord = yCoord;
        }
        public void setxDest(int xCoord)
        {
            this.destXCoord = xCoord;
        }
        public void setyDest(int yCoord)
        {
            this.destYCoord = yCoord;
        }
        public void setHeight(int height)
        {
            this.height = height;
        }
        public void setWidth(int width)
        {
            this.width = width;
        }
        public void setDestHeight(int height)
        {
            this.destHeight = height;
        }
        public void setDestWidth(int width)
        {
            this.destWidth = width;
        }
        public void setBorderL(int border)
        {
            this.borderL = border;
        }
        public void setBorderA(int border)
        {
            this.borderA = border;
        }

        public void setFpsLimit(int limit)
        {
                fpsLimit = limit;
        }

        public void setUse(bool use)
        {
            this.use = use;
        }


        public void setLocal(bool local)
        {
            this.islocal = local;
            if (islocal)
            {
                setFpsLimit(0);
                setMethod("local");
            }
            {
                setMethod("auto");
            }
        }
        public void setLinked(bool li)
        {
            destLinked=li;
        }

        public void switchUse()
        {
            use = !use;
        }
        public void switchLocal()
        {
            islocal = !islocal;
            if (islocal)
            {
                setFpsLimit(0);
            }
        }
        public void moveRight(int x)
        {
            xCoord = xCoord + x;
        }
        public void moveDown(int y)
        {
            yCoord = yCoord + y;
        }
        public bool getlocal()
        {
            return islocal;
        }
        public void setMethod(String transp)
        {
            this.transporMethod = transp;
        }
        public String getMethod()
        {
            return transporMethod;
        }
        public void switchNoSync()
        {
            noSync = !noSync;
        }
        public bool getNoSync()
        {
            return noSync;
        }
        public bool getLinked()
        {
            return destLinked;
        }
    }
}
