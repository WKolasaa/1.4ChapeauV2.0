using ChapeauModel;
using ChapeauService;

namespace ChapeauUI;

public partial class ManagerMenuAddAndUpdate : Form
{
    public ManagerMenuAddAndUpdate(MenuItem menuItem)
    {
        PrepareForm("Adjust Menu Item");
        importData(menuItem);
    }

    public ManagerMenuAddAndUpdate()
    {
        PrepareForm("Add Menu Item");
        radioButton1.Checked = true;
    }

    private void PrepareForm(string text)
    {
        InitializeComponent();
        CenterToScreen();
        cbCategory.DataSource = Enum.GetValues(typeof(ItemCategory));
        btAddMenu.Text = text;
    }

    private void btAddMenu_Click(object sender, EventArgs e)
    {
        if (txtAddMenuDesciprion.Text.Length == 0)
        {
            MessageBox.Show("Field cannot be empty!");
            return;
        }

        if (double.Parse(txtAddMenuPrice.Text) < 0 || int.Parse(txtQuantity.Text) < 0)
        {
            MessageBox.Show("Value cannot be lower then 0!");
            return;
        }

        try
        {
            var menuService = new MenuService();

            if (btAddMenu.Text == "Add Menu Item")
            {
                menuService.AddMenu(insertData());
                MessageBox.Show("Menu Item Added!");
            }
            else
            {
                menuService.UpdateMenu(insertData());
                MessageBox.Show("Menu Item Adjusted!");
            }

            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void btCancel_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void importData(MenuItem item) //import data from menu object
    {
        txtAddMenuID.Text = item.MenuItemID.ToString();
        txtAddMenuDesciprion.Text = item.Description;
        txtAddMenuPrice.Text = item.Price.ToString();
        cbCategory.SelectedItem = item.ItemType;
        txtQuantity.Text = item.Quantity.ToString();
        if (item.VAT_Category)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = true;
        }
        else
        {
            radioButton1.Checked = true;
            radioButton2.Checked = false;
        }
    }

    private MenuItem insertData() //insert data into temporary object
    {
        MenuItem tempMenu = new MenuItem();

        if (btAddMenu.Text == "Adjust Menu Item") 
            tempMenu.MenuItemID = int.Parse(txtAddMenuID.Text);
        tempMenu.Description = txtAddMenuDesciprion.Text;
        tempMenu.Price = double.Parse(txtAddMenuPrice.Text);
        tempMenu.ItemType = (ItemCategory)cbCategory.SelectedItem;
        tempMenu.Quantity = int.Parse(txtQuantity.Text);
        if (radioButton1.Checked)
            tempMenu.VAT_Category = false;
        else
            tempMenu.VAT_Category = true;

        return tempMenu;
    }

}