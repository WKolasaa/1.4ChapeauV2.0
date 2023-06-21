using ChapeauModel;
using ChapeauService;

namespace ChapeauUI;

public partial class ManagerMenuAddAndUpdate : Form
{
    private readonly bool AddForm;
    private MenuItem MenuItem;

    public ManagerMenuAddAndUpdate(bool Add, MenuItem menuItem)
    {
        InitializeComponent();
        CenterToScreen();
        cbCategory.DataSource = Enum.GetValues(typeof(ItemCategory));
        AddForm = Add;
        MenuItem = menuItem;
        if (!AddForm) // checks if user pressed add or ajust button
            UpdateForm();
    }

    private void UpdateForm()
    {
        try
        {
            importData();
            btAddMenu.Text = "Adjust Menu Item";
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void btAddMenu_Click(object sender, EventArgs e)
    {
        if (txtAddMenuDesciprion.Text.Length == 0)
        {
            MessageBox.Show("Field cannot be empty!");
            return;
        }

        if (int.Parse(txtAddMenuID.Text) < 0 || double.Parse(txtAddMenuPrice.Text) < 0)
        {
            MessageBox.Show("Value cannot be lover then 0!");
            return;
        }

        try
        {
            var menuService = new MenuService();
            if (AddForm)
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

    private void importData() //import data from menu object
    {
        txtAddMenuID.Text = MenuItem.MenuItemID.ToString();
        txtAddMenuDesciprion.Text = MenuItem.Description;
        txtAddMenuPrice.Text = MenuItem.Price.ToString();
        cbCategory.SelectedItem = MenuItem.ItemType;
        if (MenuItem.VAT_Category)
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

        tempMenu.MenuItemID = int.Parse(txtAddMenuID.Text);
        tempMenu.Description = txtAddMenuDesciprion.Text;
        tempMenu.Price = double.Parse(txtAddMenuPrice.Text);
        tempMenu.ItemType = (ItemCategory)cbCategory.SelectedItem;
        if (radioButton1.Checked)
            tempMenu.VAT_Category = false;
        else
            tempMenu.VAT_Category = true;

        return tempMenu;
    }

}