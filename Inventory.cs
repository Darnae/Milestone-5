using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Updated_Inventory
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            
           
        }

        private void Regular_Storage_Click(object sender, EventArgs e) // interface option to view initial inventory
        {
            Inventory_Manager Update_Two = new Inventory_Manager();

            Update_Two.getstorage();
        }

        private void Add_to_Inventory_Click(object sender, EventArgs e) // interface option to add items to inventory 
        {
            Inventory_Manager Update = new Inventory_Manager();

            Update.increase_storage();
        }

        private void Remove_From_Inventory_Click(object sender, EventArgs e)// interface option to remove item from inventory
        {
            Inventory_Manager Update_three = new Inventory_Manager();

            Update_three.decrease_storage();
           
        }

        private void Restock_Storage_Click(object sender, EventArgs e) // interface option to remove item from Inventory
        {
            Inventory_Manager Update_four = new Inventory_Manager();

            Update_four.restock_storage();
        }

        private void Find_Item_Click(object sender, EventArgs e) // Interface option to remove item from Inventory
        {
            Inventory_Manager Find = new Inventory_Manager();

            Find.search_storage();
        }

        private void Back_to_Cover_Click(object sender, EventArgs e)
        {
            Inventory_Cover inventory_Cover = new Inventory_Cover();

            inventory_Cover.Show();
        }
    }

    class Inventory_Manager
    {

        List<string> storage = new List<string>(); // list string to hold inventory


       
        public void Storage() // method for initial inventory items
        {
            // initial storage items

            storage.Add("Equipment");
            storage.Add("Weapons Cash");
            storage.Add("Power Tools");

        }

        public void increase_storage() // method that adds an item to inventory
        {
            Storage(); // this is so that the copiler knows to add Storage() method's information

            storage.Add("Lightbulbs");

            MessageBox.Show(storage[0] + "  +  " + storage[1] + "  +  " + storage[2] + "  +  " + storage[3]);
          

        }

        public void decrease_storage() // method deletes an item from inventory
        {
            Storage();

            storage.Remove("Equipment");

            MessageBox.Show(storage[0] + "  +  "  + storage[1]);
        }

        public void restock_storage() // restocks an deleted item from storage
        {
            Storage();

            // removes an item then immediately restocks it.

            storage.Remove("Equipment");

            storage.Add("Equipment (restocked)");

            MessageBox.Show(storage[0] + "  +  " + storage[1] + "  +  " + storage[2]);

        }

        public void search_storage() // searches for item based on criteria
        {
            Storage();

            Random random = new Random();

            string search = "";


            // if statement is so criteria automatically switches. Two criteria are used. Name and first letter


            if (random.Next(10) > 5)
            {
                search = storage.Find(x => x.Equals("Equipment"));

                MessageBox.Show("I found  " + search + "  name. ");
            }

            else
            {
                search = storage.Find(x => x.StartsWith("E"));


                MessageBox.Show("I found  " + search + "  first letter. ");
            }
        }

        public string getstorage() // returns and displays normal inventory list
        {
            Storage();

            MessageBox.Show(storage[0] + "  +  " + storage[1] + "  +  " + storage[2]);

;           return storage.ToString();
        }

    } // Class
} // NameSpace
