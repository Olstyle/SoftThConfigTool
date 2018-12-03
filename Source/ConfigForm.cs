using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.IO;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;

namespace SoftTh_Config_Tool
{
    public partial class ConfigForm : Form
    {
        private PictureBox pictureBox1 = new PictureBox();

        private Display[] display;

        private TabPage[] headTab;

        private TextBox[] headPosX;
        private TextBox[] headPosY;
        private TextBox[] headHeight;
        private TextBox[] headWidth;
        private TextBox[] borderLeft;
        private TextBox[] borderTop;
        private TextBox[] FPSText;
            

        private Label[] resText;
        private Label[] resMul;
        private Label[] xText;
        private Label[] yText;
        private Label[] topT;
        private Label[] leftT;
        private Label[] borderT;
        private Label[] transpT;

        private CheckBox[] checkOnOff;
        private CheckBox[] checkLocal;
        private CheckBox[] noSync;
        private CheckBox[] FPSlimit;

        private ComboBox[] transpBox;

        private int[] res;
        private int borderR = 0;
        private int borderL = 0;
        private bool speed = false;
        private String vsync = "0";
        private String tBuffer = "0";
        private String nonlocalFormat = "RGB16D";
        private String keepCompo = "0";
        private String aa = "0";
        private String screeny = "jpg";

        private String smooth = "1";
        private String zclear = "0";
        private String forceRe = "0";
        private String horFOV = "0";
        private String verFOV = "0";
        private String forceMulti = "0";
        private String debug = "0";
        private String compIB = "0";
        private String compTex = "0";
        private String compVB = "0";

        public ConfigForm()
        {
            InitializeComponent();      
            getdisplay();
            InitSelfmadeComps();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Dock the PictureBox to the form
            pictureBox1.Dock = DockStyle.None;
            pictureBox1.SetBounds(5, 5, ((this.Bounds.Width) - 20), (this.Bounds.Height / 2-50));
            // Connect the Paint event of the PictureBox to the event handler method.
            pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
           
            // Add the PictureBox control to the Form.
            this.Controls.Add(pictureBox1);
        }

        private void InitSelfmadeComps()
        {
            //vorfüllen
            this.NonlocalTransport.SelectedIndex = 1;
            this.screenyFormat.SelectedIndex = 0;
            this.antiAliasing.SelectedIndex = 0;
            this.vSyncControl.SelectedIndex = 0;
            this.dropCentered.SelectedIndex = 0;
            this.primTranspBox.SelectedIndex = 0;

            initDisplayTabs();
        }

        private void initDisplayTabs()
        {
            //primary tab
            primWidth.Text = display[0].getWidth().ToString();
            primHeight.Text = display[0].getHeight().ToString();
            primPosX.Text = display[0].getxCoord().ToString();
            primPosY.Text = display[0].getyCoord().ToString();

            //the rest
            int length=display.Length - 1;
            headTab = new TabPage[length];

            headPosX = new TextBox[length];
            headPosY = new TextBox[length];
            headHeight = new TextBox[length];
            headWidth = new TextBox[length];
            borderLeft = new TextBox[length];
            borderTop = new TextBox[length];
            FPSText = new TextBox[length];

            resText = new Label[length];
            resMul = new Label[length];
            xText = new Label[length];
            yText = new Label[length];
            topT = new Label[length];
            leftT = new Label[length];
            borderT= new Label[length];
            transpT = new Label[length];

            checkOnOff = new CheckBox[length];
            checkLocal = new CheckBox[length];
            noSync = new CheckBox[length];
            FPSlimit = new CheckBox[length];

            transpBox = new ComboBox[length];

            Font myFont=new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            for (int i = 0; i < length; i++)
            {
                //make the tab
                headTab[i] = new TabPage();
                   
                displayRelated.Controls.Add(headTab[i]);
                headTab[i].Location = new System.Drawing.Point(4, 22);
                headTab[i].Name = "Head" + (i+1);
                headTab[i].Padding = new System.Windows.Forms.Padding(3);
                headTab[i].Size = new System.Drawing.Size(254, 281);
                //headTab[i].TabIndex = 0;
                headTab[i].Text = "Head" + (i+1);
                headTab[i].UseVisualStyleBackColor = true;

                //make the controls
                headPosX[i] = new TextBox();
                headPosY[i] = new TextBox();
                headHeight[i] = new TextBox();
                headWidth[i] = new TextBox();
                borderLeft[i] = new TextBox();
                borderTop[i] = new TextBox();
                FPSText[i] = new TextBox();

                resText[i] = new Label();
                resMul[i] = new Label();
                xText[i] = new Label();
                yText[i] = new Label();
                topT[i] = new Label();
                leftT[i] = new Label();
                borderT[i] = new Label();
                transpT[i] = new Label();


                checkOnOff[i] = new CheckBox();
                checkLocal[i] = new CheckBox();
                noSync[i] = new CheckBox();
                FPSlimit[i] = new CheckBox();

                transpBox[i] = new ComboBox();

                //Textboxes
                headPosX[i].Font = myFont;
                headPosX[i].Location = new System.Drawing.Point(106, 95);
                headPosX[i].Name = "headPosX" + (i + 1);
                headPosX[i].Size = new System.Drawing.Size(40, 22);
                headPosX[i].Leave += new System.EventHandler(this.headPosX_Leave);
                headPosX[i].Text = display[i+1].getxCoord().ToString();

                headPosY[i].Font = myFont;
                headPosY[i].Location = new System.Drawing.Point(170, 95);
                headPosY[i].Name = "headPosY" + (i + 1);
                headPosY[i].Size = new System.Drawing.Size(40, 22);
                headPosY[i].Leave += new System.EventHandler(this.headPosY_Leave);
                headPosY[i].Text = display[i + 1].getyCoord().ToString();

                headHeight[i].Font = myFont;
                headHeight[i].Location = new System.Drawing.Point(170, 60);
                headHeight[i].Name = "headHeight" + (i + 1);
                headHeight[i].Size = new System.Drawing.Size(40, 22);
                headHeight[i].Leave += new System.EventHandler(this.headHeight_Leave);
                headHeight[i].Text = display[i + 1].getHeight().ToString();

                headWidth[i].Font = myFont;
                headWidth[i].Location = new System.Drawing.Point(106, 60);
                headWidth[i].Name = "headWidth" + (i + 1);
                headWidth[i].Size = new System.Drawing.Size(40, 22);
                headWidth[i].Leave += new System.EventHandler(this.headWidth_Leave);
                headWidth[i].Text = display[i + 1].getWidth().ToString();

                FPSText[i].Enabled = false;
                FPSText[i].Font = myFont;
                FPSText[i].Location = new System.Drawing.Point(125, 180);
                FPSText[i].Size = new System.Drawing.Size(19, 22);
                FPSText[i].Text = "0";
                FPSText[i].Leave += new EventHandler(FPSlimit_changed);
              
                borderTop[i].Font = myFont;
                borderTop[i].Location = new System.Drawing.Point(214, 141);
                borderTop[i].Name = "Btop"+(i+1);
                borderTop[i].Size = new System.Drawing.Size(38, 22);
                borderTop[i].Text = "0";
                borderTop[i].Leave += new System.EventHandler(this.topBorder_Leave);
                GlobalTip.SetToolTip(borderTop[i], "Use this to compensate for monitor bezels.");
              
                borderLeft[i].Font = myFont;
                borderLeft[i].Location = new System.Drawing.Point(126, 141);
                borderLeft[i].Name = " Bleft"+(i+1);
                borderLeft[i].Size = new System.Drawing.Size(38, 22);
                borderLeft[i].Text = "0";
                borderLeft[i].Leave += new System.EventHandler(this.leftBorder_Leave);
                GlobalTip.SetToolTip(borderLeft[i], "Use this to compensate for monitor bezels.");
               
                //labels
                resText[i].AutoSize = true;
                resText[i].Font = myFont;
                resText[i].Location = new System.Drawing.Point(19, 63);
                resText[i].Name = "resText"+(i+1);
                resText[i].Text = "Resolution :";

                resMul[i].AutoSize = true;
                resMul[i].Font = myFont;
                resMul[i].Location = new System.Drawing.Point(150, 61);
                resMul[i].Name = "resMul" + (i + 1);
                resMul[i].Text = "x";

                xText[i].AutoSize = true;
                xText[i].Font = myFont;
                xText[i].Location = new System.Drawing.Point(19, 98);
                xText[i].Name = "xText" + (i + 1);
                xText[i].Text = "Position :   X:";

                yText[i].AutoSize = true;
                yText[i].Font = myFont;
                yText[i].Location = new System.Drawing.Point(150, 98);
                yText[i].Name = "yText" + (i + 1);
                yText[i].Text = "Y:";


                topT[i].AutoSize = true;
                topT[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                topT[i].Location = new System.Drawing.Point(164, 144);
                topT[i].Text = "On top:";
                GlobalTip.SetToolTip(topT[i], "Use this to compensate for monitor bezels.");

                leftT[i].AutoSize = true;
                leftT[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                leftT[i].Location = new System.Drawing.Point(91, 144);
                leftT[i].Text = "Left :";
                GlobalTip.SetToolTip(leftT[i], "Use this to compensate for monitor bezels.");

                borderT[i].AutoSize = true;
                borderT[i].Font = myFont;
                borderT[i].Location = new System.Drawing.Point(19, 141);
                borderT[i].Text = "Borders :";
                GlobalTip.SetToolTip(borderT[i], "Use this to compensate for monitor bezels.");

                transpT[i].AutoSize = true;
                transpT[i].Font = myFont;
                transpT[i].Location = new System.Drawing.Point(25, 218); ;
                transpT[i].Text = "Nonlocal transport :";
                GlobalTip.SetToolTip(transpT[i], "Choose transport format to heads which are not local.\r\nQuality should be enough f" +
        "or most(but reduces color depth to 16bit). ");

                //checkBoxes
                checkOnOff[i].AutoSize = true;
                checkOnOff[i].Checked = true;
                checkOnOff[i].CheckState = System.Windows.Forms.CheckState.Checked;
                checkOnOff[i].Font = myFont;
                checkOnOff[i].Location = new System.Drawing.Point(22, 23);
                checkOnOff[i].Name = "checkOnOff" +(i+1);
                checkOnOff[i].Size = new System.Drawing.Size(74, 20);
                checkOnOff[i].Text = "Use";
                checkOnOff[i].CheckedChanged += new EventHandler(this.checkOnOff_CheckedChanged);

             
                checkLocal[i].AutoSize = true;
                
                checkLocal[i].Font = myFont;
                checkLocal[i].Location = new System.Drawing.Point(80, 23);
                checkLocal[i].Name = "checkLocal" + (i + 1);
                checkLocal[i].Size = new System.Drawing.Size(94, 20);
                checkLocal[i].TabIndex = 10;
                checkLocal[i].Text = "Local head";
                checkLocal[i].CheckedChanged += new EventHandler(this.checkLocal_CheckedChanged);
                GlobalTip.SetToolTip(checkLocal[i], "Disable if the corresponding screen is not connected to the primary graphicscard.");

                noSync[i].AutoSize = true;
                noSync[i].Font = myFont;
                noSync[i].Location = new System.Drawing.Point(180, 23);
                noSync[i].Name = "NoSync Head"+(i+1);
                noSync[i].Size = new System.Drawing.Size(118, 20);
                noSync[i].Text = "Don\'t sync FPS";
                noSync[i].CheckedChanged += new EventHandler(noSync_CheckedChanged);
                GlobalTip.SetToolTip(noSync[i], "Use this for slow monitors (e.g. USB).");

                
                FPSlimit[i].AutoSize = true;
                FPSlimit[i].Font = myFont;
                FPSlimit[i].Location = new System.Drawing.Point(22, 182);
                FPSlimit[i].Text = "Limit FPS to";
                FPSlimit[i].CheckedChanged += new EventHandler(FPSLimit_CheckedChanged);
                GlobalTip.SetToolTip(FPSlimit[i], "Use this for slow monitors (e.g. USB).");


                transpBox[i].DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                transpBox[i].FlatStyle = System.Windows.Forms.FlatStyle.System;
                transpBox[i].Font = myFont;
                transpBox[i].Items.AddRange(new object[] {
            "Use global setting",
            "High Quality",
            "Quality",
            "Performance"});
                transpBox[i].Location = new System.Drawing.Point(151, 217);
                transpBox[i].Size = new System.Drawing.Size(135, 24);
                GlobalTip.SetToolTip(transpBox[i], "Choose transport format to heads which are not local.\r\nQuality should be enough f" +
            "or most(but reduces color depth to 16bit). ");
                transpBox[i].SelectedIndexChanged += new System.EventHandler(this.primTranspBox_SelectedIndexChanged);
                transpBox[i].SelectedIndex = 0;

                if (display[i + 1].getlocal())
                {
                    checkLocal[i].Checked = true;
                    noSync[i].Enabled = false;
                    FPSlimit[i].Enabled = false;
                    transpT[i].Enabled = false;
                    transpBox[i].Enabled = false;
                }
                else
                {
                    checkLocal[i].Checked = false;
                    noSync[i].Enabled = true;
                    FPSlimit[i].Enabled = true;
                    transpT[i].Enabled = true;
                    transpBox[i].Enabled = true;
                }
                
                //add the controls
                headTab[i].Controls.Add(headPosX[i]);
                headTab[i].Controls.Add(headPosY[i]);
                headTab[i].Controls.Add(headHeight[i]);
                headTab[i].Controls.Add(headWidth[i]);
                headTab[i].Controls.Add(borderLeft[i]);
                headTab[i].Controls.Add(borderTop[i]);
                headTab[i].Controls.Add(FPSText[i]);

                headTab[i].Controls.Add(resText[i]);
                headTab[i].Controls.Add(resMul[i]);
                headTab[i].Controls.Add(xText[i]);
                headTab[i].Controls.Add(yText[i]);
                headTab[i].Controls.Add(topT[i]);
                headTab[i].Controls.Add(leftT[i]);
                headTab[i].Controls.Add(borderT[i]);
                headTab[i].Controls.Add(transpT[i]);


                headTab[i].Controls.Add(checkOnOff[i]);
                headTab[i].Controls.Add(checkLocal[i]);
                headTab[i].Controls.Add(noSync[i]);
                headTab[i].Controls.Add(FPSlimit[i]);
                headTab[i].Controls.Add(transpBox[i]);

                dropCentered.Items.Add("Head "+(i+1));

            }
        }
        private void pictureBox1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            // Create a local version of the graphics object for the PictureBox.
            Graphics g = e.Graphics;
            Font myFont = new Font("Microsoft Sans Serif", 11);
            double maxW = 0;

            res = getRes();
            mainRes.Text = ("Your total resolution is:\n" + res[0].ToString() + "x" + res[1].ToString());

            double maxl = 0;
            if (res[0] > ((double)res[1] * (double)pictureBox1.Bounds.Width / (double)pictureBox1.Bounds.Height))
            {
                maxl = (double)res[0];
                maxW = (double)pictureBox1.Bounds.Width - 50;
            }
            else
            {
                maxl = (double)res[1];
                maxW = (double)pictureBox1.Bounds.Height - 30;
            }
            int j = 3;

            g.FillRectangle(Brushes.Gray, new Rectangle(20, 20, (int)((double)(res)[0] / (double)maxl * maxW), (int)((double)res[1] / (double)maxl * maxW)));
            for (int i = 0; i < display.Length; i++)
            {
                if (display[i].Use())
                {
                    int x = (int)((double)display[i].getxCoord() / (double)maxl * maxW + 20.0);
                    int y = (int)((double)display[i].getyCoord() / (double)maxl * maxW + 20.0);
                    int width = (int)((double)display[i].getWidth() / (double)maxl * maxW);
                    int height = (int)((double)display[i].getHeight() / (double)maxl * maxW);

                    if (i > 0)
                    {

                        if (display[i].getlocal())
                            {
                                g.FillRectangle(Brushes.LimeGreen, new Rectangle(x, y, width, height));
                                g.DrawString("local", myFont, Brushes.White, (x + width / 2 - 20), (y + height / 2 + 22));
                            }
                        else if (0 != display[i].getFpsLimit())
                        {

                            g.FillRectangle(Brushes.Orange, new Rectangle(x, y, width, height));
                            g.DrawString("nonlocal", myFont, Brushes.White, (x + width / 2 - 20), (y + height / 2 + 35));
                            g.DrawString(("FPS limited to " + display[i].getFpsLimit()), myFont, Brushes.White, (x + width / 2 - 40), (y + height / 2 + 50));
                        }

                        else
                        {
                            g.FillRectangle(Brushes.Blue, new Rectangle(x, y, width, height));
                            g.DrawString("nonlocal", myFont, Brushes.White, (x + width / 2 - 25), (y + height / 2 + 22));
                        }
                      
                        g.DrawString(("Head " + (i)), myFont, Brushes.White, (x + width / 2 - 20), (y + height / 2 - 5));
                    }
                    else
                    {
                        g.FillRectangle(Brushes.LimeGreen, new Rectangle(x, y, width, height));
                        g.DrawString("Primary Head", myFont, Brushes.White, (x + width / 2 - 40), (y + height / 2 - 5));
                    }

                    String text1 = "x:" + display[i].getxCoord() + " y:" + display[i].getyCoord();
                    String text2 = "res:" + display[i].getWidth() + " X " + display[i].getHeight();
                    g.DrawString(text1, myFont, Brushes.White, x + 5, y + 5);
                    g.DrawString(text2, myFont, Brushes.White, x + width / 2 - 50, y + height / 2 + 10);
                    g.DrawRectangle(Pens.Black, x, y, width, height);
                }
                else
                {
                    g.DrawString(("Display nr." + (i + 1) + " is disabled."), myFont, Brushes.Black, 20, (int)((double)res[1] / (double)maxl * maxW + 20.0 * j));
                    j++;
                }
            }

            //g.DrawString(("Your render resolution should be: " + res[0] + "x" + res[1] + " !"),myFont, Brushes.Black, 20, (int)((double)res[1] / (double)maxl * maxW + 20.0 * j));
        }

        private void getdisplay()
        {
            int maxX = 0;
            int maxY = 0;
            display = new Display[Screen.AllScreens.Length];
            int prim = 0;


            for (int i = 0; i < Screen.AllScreens.Length; i++)
            {
                display[i] = new Display();
                display[i].setHeight(Screen.AllScreens[i].Bounds.Height);
                display[i].setDestHeight(display[i].getHeight());
                display[i].setWidth(Screen.AllScreens[i].Bounds.Width);
                display[i].setDestWidth(display[i].getWidth());
                display[i].setxCoord(Screen.AllScreens[i].Bounds.X);
                display[i].setyCoord(Screen.AllScreens[i].Bounds.Y);
                if (Screen.AllScreens[i].Primary)
                {
                    display[i].setLocal(true);
                    prim = i;
                }
                if (maxX > display[i].getxCoord())
                {
                    maxX = display[i].getxCoord();
                }
                if (maxY > display[i].getyCoord())
                {
                    maxY = display[i].getyCoord();
                }
            }

            /*make primary monitor monitor 0*/
            if (!Manager.Adapters[0].Information.DeviceName.Equals(Screen.AllScreens[0].DeviceName))
            {
                if (prim != 0)
                {
                    Display temp = display[0];
                    display[0] = display[prim];
                    for (int i = prim; i > 1; i--)
                    {
                        display[i] = display[i - 1];
                    }
                    display[1] = temp;
                }
            }
            /*correct coordinates and set local*/
            for (int i = 0; i < display.Length; i++)
            {
                display[i].setxCoord(display[i].getxCoord() - maxX);
                display[i].setyCoord(display[i].getyCoord() - maxY);
                if (Manager.Adapters[i].Information.DeviceId == Manager.Adapters[0].Information.DeviceId)
                {
                    display[i].setLocal(true);
                }
            }

        }
        private void readConfig(FileStream fs)
        {
            StreamReader reader = new StreamReader(fs);
            String line = "";
            int displayIndex = 0;
            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();

                if (line.StartsWith("nonlocalFormat="))
                {
                    if (line.Contains("RGB32"))
                    {
                        NonlocalTransport.SelectedIndex = 0;
                    }
                    else if(line.Contains("RGB16D"))
                    {
                        NonlocalTransport.SelectedIndex = 1;
                    }
                    else if (line.Contains("RGB16"))
                    {
                        NonlocalTransport.SelectedIndex = 2;
                    }
                }
                else if(line.StartsWith("keepComposition="))
                {
                    if(line.Contains("1"))
                    {
                        kompoBox.Checked=true;
                    }
                    else
                    {
                        kompoBox.Checked=false;
                    }
                }
                else if(line.StartsWith("smoothing="))
                {
                    if (line.Contains("1"))
                    {
                        smoothFPS.Checked = true;
                    }
                    else
                    {
                        smoothFPS.Checked = false;
                    }
                }
                else if (line.StartsWith("debugD3D="))
                {
                    if (line.Contains("1"))
                    {
                        debugMode.Checked = true;
                    }
                    else
                    {
                        debugMode.Checked = false;
                    }
                }
                else if (line.StartsWith("zClear="))
                {
                    if (line.Contains("1"))
                    {
                        
                        useZclear.Checked = true;
                    }
                    else
                    {
                        useZclear.Checked = false;
                    }
                }
                else if (line.StartsWith("vsync="))
                {
                    if (line.Contains("0"))
                    {
                        vSyncControl.SelectedIndex = 0;
                    }
                    else if (reader.ReadLine().Contains("0"))
                    {
                        vSyncControl.SelectedIndex = 1;
                    }
                    else
                    {
                        vSyncControl.SelectedIndex = 2;
                    }
                }
                else if (line.StartsWith("screenshotFormat="))
                {
                    if (line.Contains("jpg"))
                    {

                        screenyFormat.SelectedIndex = 0;
                    }
                    else if(line.Contains("bmp"))
                    {
                        screenyFormat.SelectedIndex = 1;
                    }
                    else if(line.Contains("png"))
                    {
                        screenyFormat.SelectedIndex = 2;
                    }
                }
                else if (line.StartsWith("forceResolution="))
                {
                    if (line.Contains("1"))
                    {

                        forceRes.Checked = true;
                    }
                    else
                    {
                        forceRes.Checked = false;
                    }
                }
                else if (line.StartsWith("antialiasing="))
                {
                    if (line.Contains("0"))
                    {
                        
                        antiAliasing.SelectedIndex = 0;
                    }
                    else if (line.Contains("2"))
                    {
                        antiAliasing.SelectedIndex = 1;
                    }
                    else if (line.Contains("4"))
                    {
                        antiAliasing.SelectedIndex = 2;
                    }
                    else if (line.Contains("8"))
                    {
                        antiAliasing.SelectedIndex = 3;
                    }
                }
                else if (line.StartsWith("processAffinity="))
                {
                    if (line.Contains("1"))
                    {
                        forceMultiBox.Checked = true;
                    }
                    else
                    {
                        forceMultiBox.Checked = false;
                    }
                }
                else if (line.StartsWith("FOVForceHorizontal="))
                {
                    if (line.Contains("1"))
                    {
                        horFovBox.Checked = true;
                    }
                    else
                    {
                        horFovBox.Checked = false;
                    }
                }
                else if (line.StartsWith("FOVForceVertical="))
                {
                    if (line.Contains("1"))
                    {
                        verFovBox.Checked = true;
                    }
                    else
                    {
                        verFovBox.Checked = false;
                    }
                }
                else if (line.StartsWith("compatibleIB="))
                {
                    if (line.Contains("1"))
                    {
                       compatibleIB.Checked = true;
                    }
                    else
                    {
                        compatibleIB.Checked = false;
                    }
                }
                else if (line.StartsWith("compatibleTex="))
                {
                    if (line.Contains("1"))
                    {
                        compatibleTex.Checked = true;
                    }
                    else
                    {
                        compatibleTex.Checked = false;
                    }
                }
                else if (line.StartsWith("compatibleVB="))
                {
                    if (line.Contains("1"))
                    {
                        compatibleVB.Checked = true;
                    }
                    else
                    {
                        compatibleVB.Checked = false;
                    }
                }
                else if(line.Contains("head_primary"))
                {
                    displayIndex=0;
                    displayRelated.SelectedIndex = displayIndex;
                }
                else if (line.Contains("screenMode="))
                {
                    line = line.Substring(11);
                    String[] parts = line.Split('x');
                    display[0].setDestWidth(Int32.Parse(parts[0]));
                    display[0].setDestHeight(Int32.Parse(parts[1]));
                    if (display[0].getHeight() != display[0].getDestHeight() || display[0].getWidth() != display[0].getDestWidth())
                    {
                        display[0].setLinked(false);
                    }
                    else
                    {
                        display[0].setLinked(true);
                    }
                }
                else if (line.Contains("head_"))
                {
                    displayIndex = line.ToCharArray(6, 1)[0]-48;
                    displayRelated.SelectedIndex = displayIndex;
                }
                else if (line.StartsWith("; borderA="))
                {
                    if (displayIndex > 0)
                    {
                        borderTop[displayIndex - 1].Text = line.Substring(10);
                    }

                    else
                    {
                        primBtop.Text = line.Substring(10);
                    }

                    display[displayIndex].setBorderA(Int32.Parse(line.Substring(10)));
                }
                else if (line.StartsWith("; borderL="))
                {
                    if (displayIndex > 0)
                    {
                        borderLeft[displayIndex - 1].Text = line.Substring(10);
                    }
                    else
                    {
                        primBleft.Text = line.Substring(10);
                    }
                    display[displayIndex].setBorderL(Int32.Parse(line.Substring(10)));
                }   
                else if (line.StartsWith("sourceRect="))
                {
                    line = line.Substring(11);
                    String[] parts = line.Split(',');

                    display[displayIndex].setxCoord(Int32.Parse(parts[0]));
                    display[displayIndex].setyCoord(Int32.Parse(parts[1]));
                    display[displayIndex].setWidth(Int32.Parse(parts[2]));
                    display[displayIndex].setHeight(Int32.Parse(parts[3]));
                    if (displayIndex > 0)
                    {
                        headPosX[displayIndex - 1].Text = parts[0];
                        headPosY[displayIndex - 1].Text = parts[1];
                        headWidth[displayIndex - 1].Text = parts[2];
                        headHeight[displayIndex - 1].Text = parts[3];
                    }
                    else
                    {
                        primPosX.Text = parts[0];
                        primPosY.Text = parts[1];
                        primWidth.Text = parts[2];
                        primHeight.Text = parts[3];
                    }
                }
                else if (line.StartsWith("destRect="))
                {
                    line = line.Substring(9);
                    String[] parts = line.Split(',');
                    display[displayIndex].setxDest(Int32.Parse(parts[0]));
                    display[displayIndex].setyDest(Int32.Parse(parts[1]));
                    display[displayIndex].setDestWidth(Int32.Parse(parts[2]));
                    display[displayIndex].setDestHeight(Int32.Parse(parts[3]));
                    if (display[displayIndex].getHeight() != display[displayIndex].getDestHeight() || display[displayIndex].getWidth() != display[displayIndex].getDestWidth())
                    {
                        display[displayIndex].setLinked(false);
                    }
                    else
                    {
                        display[displayIndex].setLinked(true);
                    }
                }
                else if (line.StartsWith("transportMethod="))
                {
                    line = line.Substring(16);
                    if (line.StartsWith("local"))
                    {
                        if (displayIndex > 0)
                        {
                            checkLocal[displayIndex - 1].Checked = true;
                        }
                    }
                    else if (line.Contains("auto"))
                    {

                        if (displayIndex > 0)
                        {
                            transpBox[displayIndex - 1].SelectedIndex = 0;
                            checkLocal[displayIndex - 1].Checked = false;
                        }
                    }
                    else if (line.Contains("nonlocal32"))
                    {
                        if (displayIndex > 0)
                        {
                            transpBox[displayIndex - 1].SelectedIndex = 1;
                            checkLocal[displayIndex - 1].Checked = false;
                        }
                    }
                    else if (line.Contains("nonlocal16d"))
                    {
                        if (displayIndex > 0)
                        {
                            transpBox[displayIndex - 1].SelectedIndex = 2;
                            checkLocal[displayIndex - 1].Checked = false;
                        }
                    }
                    else if (line.Contains("nonlocal16"))
                    {
                        if (displayIndex > 0)
                        {
                            transpBox[displayIndex - 1].SelectedIndex = 2;
                            checkLocal[displayIndex - 1].Checked = false;
                        }
                    }
                }
                else if (line.StartsWith("noSync="))
                {
                    if (line.Contains("0"))
                    {
                        if (displayIndex > 0)
                            noSync[displayIndex - 1].Checked = false;
                        else
                            primNoSync.Checked = false;
                    }
                    else
                    {
                        if (displayIndex > 0)
                            noSync[displayIndex - 1].Checked = true;
                        else
                            primNoSync.Checked = true;
                    }
                }
                else if (line.StartsWith("fpsLimit="))
                {
                    if (line.Substring(9).Equals("0"))
                    {
                        if (displayIndex > 0)
                            FPSlimit[displayIndex - 1].Checked = false;
                        else
                            primFPS.Checked = false;
                    }
                    else
                    {
                        if (displayIndex > 0)
                        {
                            FPSText[displayIndex - 1].Text = line.Substring(9);
                            FPSlimit[displayIndex - 1].Checked = true;
                        }
                        else
                        {
                            primFPSText.Text = line.Substring(9);
                            primFPS.Checked = true;
                        }
                    }
                }
              }
            displayRelated.SelectedIndex = 0;
            reader.Dispose();
        }
        

        private int[] getRes()
        {
            int[] coords = new int[2];
            int maxX = 0;
            int maxY = 0;
            for (int i = 0; i < display.Length; i++)
            {
                if (display[i].Use())
                {
                    int xtest = display[i].getxCoord() + display[i].getWidth();
                    if (xtest > maxX)
                    {
                        maxX = xtest;
                    }
                    int ytest = display[i].getyCoord() + display[i].getHeight();
                    if (ytest > maxY)
                    {
                        maxY = ytest;
                    }
                }
            }
            coords[0] = maxX + borderR;
            coords[1] = maxY;
            return coords;

        }

        private void addBoarderLeft(int x, int id)
        {
            int start = display[id].getxCoord();
            for (int i = 0; i < display.Length; i++)
            {
                if (display[i].getxCoord() >= start)
                {
                    display[i].moveRight(x);
                }
            }
        }

        private void addBoarderAbove(int y, int id)
        {
            int start = display[id].getyCoord();
            for (int i = 0; i < display.Length; i++)
            {
                if (display[i].getyCoord() >= start)
                {
                    display[i].moveDown(y);
                }
            }

        }
        public String finished() //builds output String
        {
            res = getRes();
            String text = "";
            int headnr = 0;
            text = "[main]"
            + "\r\n" + "renderResolution=" + res[0] + "x" + res[1]
            + "\r\n" + "nonlocalFormat=" + nonlocalFormat
            + "\r\n" + "keepComposition=" + keepCompo
            + "\r\n" + "smoothing=" + smooth
            + "\r\n" + "debugD3D=" + debug
            + "\r\n" + "zClear=" + zclear
            + "\r\n" + "vsync=" + vsync + "\r\n" + "tripleBuffer=" + tBuffer
            + "\r\n" + "screenshotFormat=" + screeny
            + "\r\n" + "dllPathD3D9=auto" + "\r\n" + "dllPathDXGI=auto" + "\r\n" + "dllPathD3D11=auto";

            text = text + "\r\n" + "\r\n" + "[overrides]";

            text = text + "\r\n" + "forceResolution=" + forceRe
            + "\r\n" + "antialiasing=" + aa
            + "\r\n" + "processAffinity=" + forceMulti
            + "\r\n" + "FOVForceHorizontal=" + horFOV
            + "\r\n" + "FOVForceVertical=" + verFOV;

            text = text + "\r\n" + "\r\n" + "[debug]";
            text = text + "\r\n" + "compatibleIB=" + compIB
           + "\r\n" + "compatibleTex=" + compTex
           + "\r\n" + "compatibleVB=" + compVB;

            for (int i = 0; i < display.Length; i++)
            {
                if (display[i].Use())
                {
                    if (headnr == 0)
                    {
                        text = text + "\r\n" + "\r\n" + "[head_primary]"
                        + "\r\n" + "; borderA=" + display[i].getBorderA()
                        + "\r\n" + "; borderL=" + display[i].getBorderL()
                        + "\r\n" + "sourceRect=" + display[i].getxCoord() + "," + display[i].getyCoord() + "," + display[i].getWidth() + "," + display[i].getHeight()
                        + "\r\n" + "screenMode=" + display[i].getDestWidth() + "x" + display[i].getDestHeight();


                    }
                    else
                    {
                        text = text + "\r\n" + "\r\n" + "[head_" + headnr + "]"
                        + "\r\n" + "; borderA=" + display[i].getBorderA()
                        + "\r\n" + "; borderL=" + display[i].getBorderL()
                        + "\r\n" + "devID=" + i
                        + "\r\n" + "sourceRect=" + display[i].getxCoord() + "," + display[i].getyCoord() + "," + display[i].getWidth() + "," + display[i].getHeight()
                        + "\r\n" + "destRect=" + display[i].getxDest() + "," + display[i].getyDest() + "," + display[i].getDestWidth() + "," + display[i].getDestHeight();
                        if (display[i].getMethod().Equals("auto"))
                        {
                            if (speed && !display[i].getlocal())
                            {
                                text = text + "\r\n" + "transportResolution=" + (int)((double)display[i].getWidth() / 2.0) + "x" + (int)((double)display[i].getHeight() / 2.0);
                            }
                            else
                            {
                                text = text + "\r\n" + "transportResolution=" + display[i].getWidth() + "x" + display[i].getHeight();
                            }
                        }
                        else
                        {
                            if (display[i].getSpeed() && !display[i].getlocal())
                            {
                                text = text + "\r\n" + "transportResolution=" + (int)((double)display[i].getWidth() / 2.0) + "x" + (int)((double)display[i].getHeight() / 2.0);
                            }
                            else
                            {
                                text = text + "\r\n" + "transportResolution=" + display[i].getWidth() + "x" + display[i].getHeight();
                            }
                        }
                        text = text + "\r\n" + "transportMethod=";

                        if (display[i].getlocal())
                        {
                            text = text + "local";
                        }
                        else
                        { 
                                text = text + display[i].getMethod();
                        }

                        if (display[i].getNoSync() && !display[i].getlocal())
                        {
                            text = text + "\r\n" + "noSync=1";
                        }
                        else
                        {
                            text = text + "\r\n" + "noSync=0";
                        }
                        text = text + "\r\n" + "fpsLimit=" + display[headnr].getFpsLimit();
                    }
                    headnr++;
                }
            }
            return text;
        }

        private void setRes(int id, int h, int w)
        {
            int oldW = display[id].getWidth();
            int widthChange = oldW - w;

            display[id].setHeight(h);
            display[id].setWidth(w);

            int start = display[id].getxCoord();
            for (int i = 0; i < display.Length; i++)
            {
                if (display[i].getxCoord() > start)
                {
                    display[i].moveRight(-widthChange);
                }
            }
            if(display[id].getLinked())
            {
                display[id].setDestHeight(h);
                display[id].setDestWidth(w);
            }
        }

        private void cleanCoords()
        {
            //reduces coordinate system to used screens
            //coordinates left of the first used screen are negative
            bool first = true;
            int minX = 0;
            int minY = 0;
            for (int i = 0; i < display.Length; i++)
            {
                if (display[i].Use() && first)
                {
                    minX = display[i].getxCoord()-display[i].getBorderL();
                    minY = display[i].getyCoord()-display[i].getBorderA();
                    first = false;
                }
                else if (display[i].Use())
                {
                    if ((display[i].getxCoord() - display[i].getBorderL()) < minX)
                    {
                        minX = display[i].getxCoord() - display[i].getBorderL();
                    }
                    if ((display[i].getyCoord() - display[i].getBorderA()) < minY)
                    {
                        minY = display[i].getyCoord() - display[i].getBorderA();
                    }
                }
            }
            for (int i = 0; i < display.Length; i++)
            {
                display[i].moveRight(-minX+borderL);
                display[i].moveDown(-minY);
            }

        }

        private void centerOn(int center)
        {
            borderR = 0;
            borderL = 0;
            cleanCoords();
            int left = display[center].getxCoord();
            int right = getRes()[0] - display[center].getxCoord() - display[center].getWidth();
            if (left > right)
            {
                borderR = left - right;
            }
            else if (left < right)
            {
                borderL = right - left;
                for (int i = 0; i < display.Length; i++)
                {
                    display[i].moveRight(borderL);
                }
            }
            cleanCoords();
            refreshTexts();
        }

        private void NonlocalTransport_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (NonlocalTransport.SelectedIndex)
            {
                case 0:
                    nonlocalFormat = "RGB32";
                    break;
                case 1:
                    nonlocalFormat = "RGB16D";
                    break;
                case 2:
                    nonlocalFormat = "RGB16";
                    speed = true;
                    break;
                default:
                    break;

            }
        }

        private void refreshTexts()
        {
            primPosX.Text = display[0].getxCoord().ToString();
            primPosY.Text = display[0].getyCoord().ToString();
            primHeight.Text = display[0].getHeight().ToString();
            primWidth.Text = display[0].getWidth().ToString();
            for (int i = 0; i < display.Length - 1; i++)
            {
                headPosX[i].Text = display[i + 1].getxCoord().ToString();
                headPosY[i].Text = display[i + 1].getyCoord().ToString();
                headHeight[i].Text = display[i + 1].getHeight().ToString();
                headWidth[i].Text = display[i + 1].getWidth().ToString();
            }

        }
        private void screenyFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (screenyFormat.SelectedIndex)
            {

                case 0:
                    screeny = "jpg";
                    break;
                case 1:
                    screeny = "bmp";
                    break;
                case 2:
                    screeny = "png";
                    break;
                default:
                    break;
            }
        }

        private void smoothFPS_CheckedChanged(object sender, EventArgs e)
        {
            if (smoothFPS.Checked)
            {
                smooth = "1";
            }
            else
            {
                smooth = "0";
            }
        }

        private void useZclear_CheckedChanged(object sender, EventArgs e)
        {
            if (useZclear.Checked)
            {
                zclear = "1";
            }
            else
            {
                zclear = "0";
            }
        }

        private void debugMode_CheckedChanged(object sender, EventArgs e)
        {
            if (debugMode.Checked)
            {
                debug = "1";
            }
            else
            {
                debug = "0";
            }
        }

        private void antiAliasing_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (antiAliasing.SelectedIndex)
            {

                case 0:
                    aa = "0";
                    break;
                case 1:
                    aa = "2";
                    break;
                case 2:
                    aa = "4";
                    break;
                case 3:
                    aa = "8";
                    break;
                default:
                    break;
            }
        }

        private void vSyncControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (vSyncControl.SelectedIndex)
            {
                case 0:
                    vsync = "0";
                    break;
                case 1:
                    vsync = "1";
                    break;
                case 2:
                    vsync = "1";
                    tBuffer = "1";
                    break;
                default:
                    break;
            }
        }

        private void forceRes_CheckedChanged(object sender, EventArgs e)
        {
            if (forceRes.Checked)
            {
                forceRe = "1";
            }
            else
            {
                forceRe = "0";
            }
        }

        private void horFovBox_CheckedChanged(object sender, EventArgs e)
        {
            if (horFovBox.Checked)
            {
                horFOV = "1";
            }
            else
            {
                horFOV = "0";
            }

        }

        private void verFovBox_CheckedChanged(object sender, EventArgs e)
        {
            if (verFovBox.Checked)
            {
                verFOV = "1";
            }
            else
            {
                verFOV = "0";
            }
        }

        private void forceMultiBox_CheckedChanged(object sender, EventArgs e)
        {
            if (forceMultiBox.Checked)
            {
                forceMulti = "1";
            }
            else
            {
                forceMulti = "0";
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.Title = "Save your Config File";
            saveFileDialog1.FileName="config.SoftTHConfig";
            saveFileDialog1.ShowDialog();
             if(saveFileDialog1.FileName != "")
             {
                 FileStream fs = (FileStream)saveFileDialog1.OpenFile();
                 StreamWriter wStream = new StreamWriter(fs);
                 wStream.Write(finished());
                 wStream.Close();
             }
             saveFileDialog1.Dispose();
   
        }

        private void primWidth_Leave(object sender, EventArgs e)
        {
            try
            {
                int h = Convert.ToInt32(primHeight.Text);
                int w = Convert.ToInt32(primWidth.Text);          
                setRes(0,h,w);
            }
            catch (Exception)
            {
            }
            refreshTexts();
            pictureBox1.Refresh();
            
        }

        private void primHeight_Leave(object sender, EventArgs e)
        {
            try
            {
                int h = Convert.ToInt32(primHeight.Text);
                int w = Convert.ToInt32(primWidth.Text);               
                setRes(0, h, w);
            }
            catch (Exception)
            {
            }
            refreshTexts();
            pictureBox1.Refresh();
        }

        private void primPosX_Leave(object sender, EventArgs e)
        {
            try
            {
                display[0].setxCoord(Convert.ToInt32(primPosX.Text));
            }
            catch (Exception)
            {
            }

            pictureBox1.Refresh();
        }

        private void primPosY_Leave(object sender, EventArgs e)
        {
            try
            {
                display[0].setyCoord(Convert.ToInt32(primPosY.Text));
            }
            catch (Exception)
            {
            }

            pictureBox1.Refresh();
        }

        private void headPosX_Leave(object sender, EventArgs e)
        {
            try
            {
                display[displayRelated.SelectedIndex].setxCoord(Convert.ToInt32(headPosX[displayRelated.SelectedIndex-1].Text));
            }
            catch (Exception)
            {
            }

            pictureBox1.Refresh();
        }

        private void headPosY_Leave(object sender, EventArgs e)
        {
            try
            {
                display[displayRelated.SelectedIndex].setyCoord(Convert.ToInt32(headPosY[displayRelated.SelectedIndex-1].Text));
            }
            catch (Exception)
            {
            }

            pictureBox1.Refresh();
        }
        private void headHeight_Leave(object sender, EventArgs e)
        {
            try
            {
                int h = Convert.ToInt32(headHeight[displayRelated.SelectedIndex-1].Text);
                int w = Convert.ToInt32(headWidth[displayRelated.SelectedIndex-1].Text);
                setRes(displayRelated.SelectedIndex, h, w);
            }
            catch (Exception)
            {
            }
            refreshTexts();
            pictureBox1.Refresh();
            
        }
        private void headWidth_Leave(object sender, EventArgs e)
        {
            try
            {
                int h = Convert.ToInt32(headHeight[displayRelated.SelectedIndex-1].Text);
                int w = Convert.ToInt32(headWidth[displayRelated.SelectedIndex-1].Text);
                setRes(displayRelated.SelectedIndex, h, w);
            }
            catch (Exception)
            {
            }
            refreshTexts();
            pictureBox1.Refresh();
        }

        private void checkOnOff_CheckedChanged(object sender, EventArgs e)
        {
            display[displayRelated.SelectedIndex].switchUse();
            cleanCoords();
            refreshTexts();
            pictureBox1.Refresh();
        }

        private void checkLocal_CheckedChanged(object sender, EventArgs e)
        {   try
            {
                if (checkLocal[displayRelated.SelectedIndex - 1].Checked)
                {
                    display[displayRelated.SelectedIndex].setLocal(true);

                    noSync[displayRelated.SelectedIndex - 1].Enabled = false;
                    FPSlimit[displayRelated.SelectedIndex - 1].Enabled = false;
                    FPSText[displayRelated.SelectedIndex - 1].Enabled = false;
                    transpBox[displayRelated.SelectedIndex - 1].Enabled = false;
                    transpT[displayRelated.SelectedIndex - 1].Enabled = false;
                    display[displayRelated.SelectedIndex].setFpsLimit(0);
                }
                else
                {
                    display[displayRelated.SelectedIndex].setLocal(false);

                    noSync[displayRelated.SelectedIndex - 1].Enabled = true;
                    FPSlimit[displayRelated.SelectedIndex - 1].Enabled = true;
                    transpBox[displayRelated.SelectedIndex - 1].Enabled = true;
                    transpT[displayRelated.SelectedIndex - 1].Enabled = true;
                    if (FPSlimit[displayRelated.SelectedIndex - 1].Checked)
                    {
                        FPSText[displayRelated.SelectedIndex - 1].Enabled = true;
                        display[displayRelated.SelectedIndex].setFpsLimit(Convert.ToInt32(FPSText[displayRelated.SelectedIndex - 1].Text));
                    }
                }         
              
            }catch (Exception)
                 { }
            pictureBox1.Refresh();
        }

        private void kompoBox_CheckedChanged(object sender, EventArgs e)
        {
            if (kompoBox.Checked)
            {
                keepCompo = "1";
            }
            else
            {
                keepCompo = "0";
            }
        }
        private void noSync_CheckedChanged(object sender, EventArgs e)
        {  
                display[displayRelated.SelectedIndex].switchNoSync();
        }

        private void leftBorder_Leave(object sender, EventArgs e)
        {
            try
            {
                int border = Convert.ToInt32(((TextBox)sender).Text);
                addBoarderLeft((border-display[displayRelated.SelectedIndex].getBorderL()),displayRelated.SelectedIndex);
                display[displayRelated.SelectedIndex].setBorderL(border);
                refreshTexts();
            }
            catch (Exception)
            {
            }
            pictureBox1.Refresh();
        }


        private void topBorder_Leave(object sender, EventArgs e)
        {
            try
            {
                int border = Convert.ToInt32(((TextBox)sender).Text);
                addBoarderAbove((border - display[displayRelated.SelectedIndex].getBorderA()), displayRelated.SelectedIndex);
                display[displayRelated.SelectedIndex].setBorderA(border);
                refreshTexts();
            }
            catch (Exception)
            {
            }
            pictureBox1.Refresh();
        }
        private void FPSlimit_changed(object sender, EventArgs e)
        {
             try
            {
                display[displayRelated.SelectedIndex].setFpsLimit(Convert.ToInt32(((TextBox)sender).Text));
             }catch(Exception)
             {}
             pictureBox1.Refresh();
        }

        private void FPSLimit_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                FPSText[displayRelated.SelectedIndex - 1].Enabled = true;
                try
                {
                    display[displayRelated.SelectedIndex].setFpsLimit(Convert.ToInt32(FPSText[displayRelated.SelectedIndex - 1].Text));
                }
                catch (Exception)
                { }
    
            }
            else
            {
                FPSText[displayRelated.SelectedIndex - 1].Enabled = false;
                display[displayRelated.SelectedIndex].setFpsLimit(0);
            }
            pictureBox1.Refresh();
        }

        private void compatibleIB_CheckedChanged(object sender, EventArgs e)
        {
            if (compatibleIB.Checked)
            {
                compIB = "1";
            }
            else
            {
                compIB = "0";
            }
        }

        private void compatibleTex_CheckedChanged(object sender, EventArgs e)
        {
            if (compatibleTex.Checked)
            {
                compTex = "1";
            }
            else
            {
                compTex = "0";
            }
        }

        private void compatibleVB_CheckedChanged(object sender, EventArgs e)
        {
            if (compatibleVB.Checked)
            {
                compVB = "1";
            }
            else
            {
                compVB = "0";
            }
        }

        private void checkCentered_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCentered.Checked)
            {
                dropCentered.Enabled = true;
                centerOn(dropCentered.SelectedIndex);
            }
            else
            {
                dropCentered.Enabled = false;
                borderL = 0;
                borderR = 0;
                cleanCoords();
            }
            pictureBox1.Refresh();
        }

        private void dropCentered_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkCentered.Checked)
            {
                centerOn(dropCentered.SelectedIndex);
            }
            pictureBox1.Refresh();
        }

        private void primTranspBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (((ComboBox)sender).SelectedIndex)
            {
                case 0:
                    display[displayRelated.SelectedIndex].setMethod("auto");
                    display[displayRelated.SelectedIndex].setSpeed(speed);
                    break;
                case 1:
                     display[displayRelated.SelectedIndex].setMethod( "nonlocal32");
                     display[displayRelated.SelectedIndex].setSpeed(false);
                    break;
                case 2:
                     display[displayRelated.SelectedIndex].setMethod("nonlocal16d");
                     display[displayRelated.SelectedIndex].setSpeed(false);
                    break;
                case 3:
                     display[displayRelated.SelectedIndex].setMethod("nonlocal16d");
                     display[displayRelated.SelectedIndex].setSpeed( true);
                    break;
                default:
                    break;

            }
        }

        private void load_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Title = "Load your Config File";
            openFileDialog1.FileName = "config.SoftTHConfig";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = (FileStream)openFileDialog1.OpenFile();
                readConfig(fs);
            }
            openFileDialog1.Dispose();
            pictureBox1.Refresh();
            refreshTexts();
        }
    }
}
