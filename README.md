# 🏷️ Point of Sale (POS) System for Small Businesses

![C#](https://img.shields.io/badge/Language-C%23-blue) 
![WinForms](https://img.shields.io/badge/Framework-WinForms-orange)
![SQL Server](https://img.shields.io/badge/Database-SQL%20Server-red)

A **lightweight desktop POS application** built using **C# (WinForms), .NET Framework, and SQL Server**.  
Ideal for mini-markets, mobile phone shops, and other small businesses, focusing on **fast transactions, inventory management, and operational efficiency**.

---

## ✨ Key Features

> 💡 **Product & Inventory Management**
- Register products and manage stock levels.  
- Automatic stock tracking after each sale, return, or purchase.  
- Notifications for critical low-stock items.

> 💡 **Supplier & User Management**
- Maintain supplier records and contact details.  
- Manage system users with role-based access.  

> 💡 **Dedicated Cashier Interface**
- Quick, intuitive POS screen for fast transactions.  
- Supports barcode scanning or manual product search.  

> 💡 **Order Handling**
- Process returns and canceled orders seamlessly.  
- Automatic adjustment of inventory for returns/cancellations.  

> 💡 **Reports & Analytics**
- Generate sales and inventory reports.  
- Monitor daily and monthly transactions for better decision-making.

---

## 📥 Installation & Setup

1️⃣ **Open Project**  
Open the `.sln` solution file in **Visual Studio**.

2️⃣ **Restore Dependencies**  
Restore **NuGet packages** if needed.

3️⃣ **Prepare the Database**  
Open **SQL Server Management Studio (SSMS)** and run the provided `.sql` script to create tables and seed initial data.

4️⃣ **Update Configuration**  
Set your SQL Server connection string in: WindowsFormsApplication6\DBconnect.cs

5️⃣ **Run Application**  
Press **F5** in Visual Studio to launch the POS system.
