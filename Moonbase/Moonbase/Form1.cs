using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moonbase
{
    public partial class MainForm : Form
    {
        // A class for initializing room objects
        public class baseRoom
        {
            // object attributes with methods to get and set values
            public string roomName { get; set; }
            public string roomImg { get; set; }
            public string roomDesc { get; set; }

            // Constructor to initialize objects of the class
            public baseRoom(string roomName, string roomImg, string roomDesc)
            {
                this.roomName = roomName;
                this.roomImg = roomImg;
                this.roomDesc = roomDesc;
            }
        }

        public MainForm()
        {
            // A try/catch block that will attempt to initialize the mainform, and if initialization fails, 
            // will prompt the user to check the traceback stack for the cause of failure.
            try
            {
                InitializeComponent();
            }
            catch { Console.WriteLine("MainForm Initialization failed. Verify error in stack traceback"); }
        }

        // initialize objects of the baseRoom class using the class constructor and pass arguments using the information in roomArray
        baseRoom RxCtrlRm = new baseRoom(roomArray[0, 0], roomArray[0, 1], roomArray[0, 2]);
        baseRoom HrtRm = new baseRoom(roomArray[1, 0], roomArray[1, 1], roomArray[1, 2]);
        baseRoom LvgRm = new baseRoom(roomArray[2, 0], roomArray[2, 1], roomArray[2, 2]);
        baseRoom BsCtrlRm = new baseRoom(roomArray[3, 0], roomArray[3, 1], roomArray[3, 2]);
        baseRoom BdRm = new baseRoom(roomArray[4, 0], roomArray[4, 1], roomArray[4, 2]);
        baseRoom Ktn = new baseRoom(roomArray[5, 0], roomArray[5, 1], roomArray[5, 2]);
        baseRoom Hlwy = new baseRoom(roomArray[6, 0], roomArray[6, 1], roomArray[6, 2]);

        // An array that contains all of the rooms' information (Room name, img path, and description)
        public static string[,] roomArray = {
            { "Reactor Control Room", "Reactor_Control_Room.jpg",
@"Welcome to the central energy hub of MoonBase Leviathan, the Reactor Control Room.
As you stand at the entrance of the Reactor Compartment, you see the flashing lights
of servers and computers, hear the clicks of switches and the soft hum of whirring hard drives
and electricity coursing all around you. Ahead is the window to the logs office where a
receptionist patiently sits reading the latest magazine issue about news from back home.
You two seem to be the only ones around." },

            { "Horticulture Room", "Horticulture_Room.jpg",
@"Aaaah, the fresh scent of herbs and produce glide to your nostrils as you enter the 
the Horticulture room. It's amazing to look at the greenery surrounding you.
And to think, all that is this delicate ecosystem, is sustaining you while in the harsh
environment of cold, barren space, here on the moon. What an incredible wonder. 
It's nice to get some fresh air, but you should probably leave the gardener to their work."},

            { "Living Area", "Living_Room.jpg",
@"You find yourself in the base's Living Area, an open, lowly lit, cozy room. 
Ahead of you, through the viewing glass, you can see the Earth, a welcoming sight of comfort.
You consider going to the bar to grab a drink, and the cushioned chairs beckon to you. 
It seems lively in here at the moment as a few others are already relaxing and enjoying 
themselves by the entertainment screen, quietly talking. Do you stay a minute to partake?"},

            { "Base Control Room", "Control_Room.jpg",
@"Now THIS is spectacular sight, up here in the Base's Control room.
High above the surface, in the thin upper atmosphere, you can see miles and miles of the
moon's surface, while the gently rotating orb in the center depicts its entirety. 
Control is commonly busy as the base commander and his cadre work to keep the entire 
base's systems online and functioning, and directing incoming and outgoing spacecraft and 
communications. Such a wonder, the complexity of it all, and this the heart of it all. 
Or is it, the brain of it all?"},
            { "Bedroom", "Bedroom.jpg",
@"You walk in to your bedroom and breathe a sigh of relief. You've been walking around on
on your feet all day, and can already feel the satisfaction of kicking off your shoes, getting
under the bed covers, and closing your eyes for an evening of well needed sleep. 
The air is cool, but the sheets are toasty. Do climb in and call out to the AI to turn off 
the lights so you may bask in the soft glow of the night sky outside your window?"},
            { "Kitchen", "Kitchen.jpg",
@"MMMMM, You walk into the kitchen and immediately the aroma of delicious herbs and spices
hit you, and causes your mouth to water. You smack your lips as you saunter up to the 
stewing pot of vegetables. Just as you dip the ladle into the mixture on the stove, 
the cook runs up and SMACKS your hand, 'Hey! It's not done yet. Patience is the secret 
to a great meal.' Maybe you should come back in a little while, and be sure to bring an
appetite!"},
            { "Hallway", "Hallway.jpg",
@"The main hallway, where all paths lead to and from. So many choices. Just remember,
the most important step a person can take is the next one. 
Where are you going to take yours?"}
        };

        // Declare a public string variable to track the current room, set it to reference the first room upon the form loading
        public string currentRoom = "RxCtrlRm";

        // A method that will pass strings associated with the requested room's attributes and will populate the desired form objects with its information
        public void changeRooms(string rmName, string rmImg, string rmDescr)
        {
            // a string with the root image path
            string img_path = "C:\\Users\\ephar\\UAT\\CSC202\\Moonbase\\Moonbase\\Resources\\";
            // append the root image path with the file of the requested room 
            img_path += rmImg;

            // A try/catch statement that will set the background image of the form to a defualt image, and default name and description
            // if the requested image file path cannot be found
            try
            {
                // declare and create an image variable from the above path
                Image img = Image.FromFile(img_path);
                // set the background image of the form to the chosen image
                BackgroundImage = img;
                // set the roomName textbox text using the arrayed index
                TextboxRoomName.Text = rmName;
                // set the roomDescription textbox text using the arrayed index
                TextboxRoomDescription.Text = rmDescr;
            }
            catch
            {
                // set the background image of the form to a default image
                BackgroundImage = Properties.Resources.defualt;
                // set the roomName textbox text using a default entry
                TextboxRoomName.Text = "Restricted Area";
                // set the roomDescription textbox text using a default entry
                TextboxRoomDescription.Text = @"You have stumbled into a restricted area. 
Please turn around and return to your barracks. Violators will not be allowed to remain onboard. 
For further guidance or authorization, speak with the Commanding Officer.";
            }



            // An array containing room button objects and another containing possible designations for the current room
            Button[] rmArr = { ButtonRxCtrlRm, ButtonHorticultureRm, ButtonLivingRm, ButtonBaseCtrlRm, ButtonKitchen, ButtonBedroom, ButtonHallway};
            string[] crtRmArr = { "RxCtrlRm", "HrtRm", "LvgRm", "CtrlRm", "Ktn", "BdRm", "Hlwy" };
            
            // Declare the variable by which to iterate through a for loop
            int i;

            // A for loop using the length of the rmArr, that will incrementally increase 
            for (i = 0; i < rmArr.Length; i++)
            {
                // determine the current room, and enable or disable the corresponding nav button
                if (currentRoom == crtRmArr[i])
                {
                    rmArr[i].Enabled = false;
                }
                // when testing the default try/catch block, the user will only be permitted access to the bedroom only, via the nav button, 
                // and the map will be disabled to prevent access to the other rooms via the go_to_room menu
                else if (currentRoom == "Test")
                {
                    if (rmArr[i] == ButtonBedroom)
                    { 
                      rmArr[i].Enabled = true;
                      ButtonMap.Enabled = false;
                    }
                    else
                    { rmArr[i].Enabled = false; }
                }
                else
                {
                    rmArr[i].Enabled = true;
                }
            }
        }

        // For the following nav button _click events, set the currentRoom value to the requested room 
        // and call the changeRoom method passing the appropriate room object attributes
        // Menustrip events will call the related button_click events
        private void ButtonRxCtrlRm_Click(object sender, EventArgs e)
        { 
            currentRoom = "RxCtrlRm";
            changeRooms(RxCtrlRm.roomName, RxCtrlRm.roomImg, RxCtrlRm.roomDesc);
        }

        private void ButtonHorticultureRm_Click(object sender, EventArgs e)
        {
            currentRoom = "HrtRm";
            changeRooms(HrtRm.roomName, HrtRm.roomImg, HrtRm.roomDesc);
        }

        private void ButtonLivingRm_Click(object sender, EventArgs e)
        {
            currentRoom = "LvgRm";
            changeRooms(LvgRm.roomName, LvgRm.roomImg, LvgRm.roomDesc);
        }

        private void ButtonBaseCtrlRm_Click(object sender, EventArgs e)
        {
            currentRoom = "CtrlRm";
            changeRooms(BsCtrlRm.roomName, BsCtrlRm.roomImg, BsCtrlRm.roomDesc);
        }

        private void ButtonBedroom_Click(object sender, EventArgs e)
        {
            currentRoom = "BdRm";
            changeRooms(BdRm.roomName, BdRm.roomImg, BdRm.roomDesc);
            if (currentRoom == "BdRm") { ButtonMap.Enabled = true; }
        }

        private void ButtonHallway_Click(object sender, EventArgs e)
        {
            currentRoom = "Hlwy";
            changeRooms(Hlwy.roomName, Hlwy.roomImg, Hlwy.roomDesc);
        }

        private void ButtonKitchen_Click(object sender, EventArgs e)
        {
            currentRoom = "Ktn";
            changeRooms(Ktn.roomName, Ktn.roomImg, Ktn.roomDesc);
        }

        private void ButtonMap_Click(object sender, EventArgs e)
        {
            BaseMapPanel.Visible = true;
        }

        private void closeMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaseMapPanel.Visible = false;
        }

        private void bedroomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ButtonBedroom_Click(sender, e);
        }

        private void livingRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ButtonLivingRm_Click(sender, e);
        }

        private void kitchenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ButtonKitchen_Click (sender, e);    
        }

        private void horticultureRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ButtonHorticultureRm_Click(sender, e);  
        }

        private void reactorControlRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ButtonRxCtrlRm_Click(sender, e);    
        }

        private void controlRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ButtonBaseCtrlRm_Click  (sender, e);    
        }

        private void hallwayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ButtonHallway_Click (sender, e);
        }

        private void ButtonTest_Click(object sender, EventArgs e)
        {
            currentRoom = "Test";
            changeRooms("TestName", "TestImg", "TestDescription");
        }
    }
}

