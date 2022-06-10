using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryTree
{
    public partial class Form1 : Form
    {
        public Tree tree = new Tree();
        public static TreeEvent treeEvent = new TreeEvent();


        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            treeEvent.onInsert(50);
            treeEvent.onInsert(30);
            treeEvent.onInsert(90);
            treeEvent.onInsert(70);
            treeEvent.onInsert(10);
            treeEvent.onInsert(80);
            treeEvent.onInsert(40);
            treeEvent.onInsert(20);
            treeEvent.onInsert(100);
            treeEvent.onInsert(60);

            treeEvent.onTraverse();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
