//Program 3
//CIS 200-75-4248
//James Cook
//5441819

using Prog3Start;
using System.Xml.Serialization;

namespace Prog2Start
{
    public partial class FurnitureForm : Form
    {

        public FurnitureForm()
        {
            InitializeComponent();
            furnitures = new List<Furniture>();
        }

        private List<Furniture> furnitures;

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Program 3. \nJames Cook\n5441819", "Program 3 About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void couchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CouchForm toCreate = new CouchForm();
            toCreate.ShowDialog();
            if (toCreate.DialogResult == DialogResult.OK)
            {
                string[] labels = new string[3];
                labels[0] = "Couch";
                labels[1] = toCreate.CreatedCouch.Weight.ToString();
                labels[2] = toCreate.CreatedCouch.Category.ToString();
                ListViewItem cItem = new ListViewItem(labels);
                furnitureListView.Items.Add(cItem);
                furnitures.Add(toCreate.CreatedCouch);
                toCreate.Dispose();
            }
        }

        private void deskChairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeskChairForm toCreate = new DeskChairForm();
            toCreate.ShowDialog();
            if (toCreate.DialogResult == DialogResult.OK)
            {
                string[] labels = new string[3];
                labels[0] = "Desk Chair";
                labels[1] = toCreate.CreatedChair.Weight.ToString();
                labels[2] = toCreate.CreatedChair.Category.ToString();
                ListViewItem dItem = new ListViewItem(labels);
                furnitureListView.Items.Add(dItem);
                furnitures.Add(toCreate.CreatedChair);
                toCreate.Dispose();
            }
        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            if (furnitureListView.SelectedIndices.Count > 0)
            {
                int index = furnitureListView.SelectedIndices[0];
                MessageBox.Show(furnitures[index].ToString(), "Furniture Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        //save menu 
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //shows save dialog with extension as XML
            SaveFileDialog saveFileDialog = new SaveFileDialog()            
            {
                Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*",
                Title = "Save as XML",
                DefaultExt = "xml",
                AddExtension = true,
            };

            //after pressing ok serialize the furnitures list and output to the selected file name.
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {                
                XmlSerializer xmlserializer = new XmlSerializer(typeof(List<Furniture>));
                using (StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName))
                {
                    xmlserializer.Serialize(streamWriter, furnitures);
                }
            }
        }
        //load menu
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //shows load dialog with extension as XML
            OpenFileDialog openFileDialog = new OpenFileDialog()            
            {
                Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*",
                Title = "Open XML File",
                DefaultExt = "xml",
                AddExtension = true,
            };

            //after pressing ok initialize the list xmlFile and set it to deserialized opened file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {               
                XmlSerializer xmlserializer = new XmlSerializer(typeof(List<Furniture>));
                List<Furniture> xmlFile;
                using (StreamReader streamReader = new StreamReader(openFileDialog.FileName))
                {
                    xmlFile = (List<Furniture>)xmlserializer.Deserialize(streamReader);
                }
                
                //add the list(s) to the end of the furnitures
                furnitures.AddRange(xmlFile);

                //similar logic used to add furniture to the list view, with foreach loop
                foreach (Furniture furniture in xmlFile)
                {
                    string[] labels = new string[3];
                    labels[0] = furniture.GetType().Name;
                    labels[1] = furniture.Weight.ToString();
                    labels[2] = furniture.Category.ToString();
                    ListViewItem dItem = new ListViewItem(labels);
                    furnitureListView.Items.Add(dItem);
                }
            }
        }

        //simple button to clear the list
        private void clearButton_Click(object sender, EventArgs e)
        {
            furnitures.Clear();
            furnitureListView.Items.Clear();
        }       
    }

}
