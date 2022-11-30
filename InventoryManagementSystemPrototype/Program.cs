namespace InventoryManagementSystemPrototype
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
            //Application.Run(new ManageCategories());
            //Application.Run(new ManageUsers());
            //Application.Run(new ManageProducts());
            //Application.Run(new ManageSuppliers());
            //Application.Run(new ManageOrders());
            //Application.Run(new ViewOrders());
            //Application.Run(new ManageProductsEMP());
        }
    }
}