# VendingService

VendingService is a web-based tool for vending machines to facilitate the purchasing and distribution of products through a digital interface.

The source code is written in C#, using Visual Studio .NET Core with an MVC Framework and Razor pages. The most relevant files and their hierarchy are as follows:

    - Models
        -IndexViewModel.cs
        -Soda.cs
        -VendingSession.cs
        -VendingStates.cs
        -IndexViewModel.cs
    - Views
        -Index.cshtml
    - Controller
        -HomeController.cs
    - WWWroot
        -inventory.json

# Adding Sodas to the Vending List

To add a new product to the vending list, adjust inventory.json to include the new soda and place the corresponding image representing it in the wwwroot/pictures folder. It will automatically populate it in the view.

# Updating Inventory

inventory.json updates on the activation of the SoldSoda state. It is decremented every time a sold is purchased and is updated with each transaction.
