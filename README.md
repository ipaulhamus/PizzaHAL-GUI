# PizzaHAL-GUI
A pizza ordering web application created in C# using the Blazor framework within .NET 8.

- *What Does It Do?*
Similar to a production pizza ordering service, this site allows the user to create a cart of customizable food items. The page includes easy to read menu displays that clearly show the prices and available customization for each item. Once they have finished ordering, the user checks out at the end of the process. An extra charge is added to the subtotal if the user chooses to get their order delivered rather than picking it up. The site includes separate pages for each of the item types and checkout process, with the pages being navigatable through a navigation bar. This site was created for a project early within my programming journey, so the source code includes some redundant statements and poor optimization; however, this project still demonstrates many skills in .NET, Blazor, and web design.

- *How Does It Work?*
The UI for this page was created using HTML with CSS styling. In addition, many of the image assets such as the menus and header banner were created using Photoshop. The site's functionality makes use of object oriented programming principles, using an "Items" class an abstract parent class to each type of food item the user can order. When the user adds an item to the cart, it is added to a list of objects. Finally, when the user enters the "Checkout" page, it iterates through the list of "Item" objects and displays the sub-total of the prices of each item in the cart. The user then can choose whether they want delivery or pick-up, with the final order price being displayed once they make their choice.

This project demonstrates a solid understanding of .NET 8, the Blazor framework, object oriented programming, HTML & CSS, and C#.
