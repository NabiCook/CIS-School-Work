# CIS Coursework Portfolio

test-upload

---

## Featured Projects

### CIS 411: Web-Based Application Development

This was a semester-long group project to build a web application based on .NET MVC. Microsoft Azure database server was used as a backend of this app to store and handle SQL queries.

**Key Features Implemented:**

* **Secure Menu Access:** The messaging menu is only visible to authenticated users. The top navigation bar dynamically changes based on the user's login status.
    * *Logged Out View (No "Messages" link)*
        ![Logged out view](https://raw.githubusercontent.com/NabiCook/CIS-School-Work/main/CIS411%20-%20Web%20Application%20Development/program_screenshots/2025-04-23%2021_33_17-Home%20Page%20-%20CIS411Project%20and%2078%20more%20pages%20-%20Personal%20-%20Microsoft_%20Edge.jpg)
    * *Logged In View (With "Messages" link)*
        ![Logged in view](https://raw.githubusercontent.com/NabiCook/CIS-School-Work/main/CIS411%20-%20Web%20Application%20Development/program_screenshots/2025-04-23%2021_33_33-Home%20Page%20-%20CIS411Project%20and%2078%20more%20pages%20-%20Personal%20-%20Microsoft_%20Edge.jpg)

* **Private Inbox:** Each user can only view messages sent directly to them. This was achieved by adding a `receiver` field to the database and filtering messages based on the currently logged-in user.
    * *Users can only see messages where they are the recipient:*
        ![Inbox view](https://raw.githubusercontent.com/NabiCook/CIS-School-Work/main/CIS411%20-%20Web%20Application%20Development/program_screenshots/2025-04-23%2021_33_44-Messages%20-%20CIS411Project%20and%2078%20more%20pages%20-%20Personal%20-%20Microsoft_%20Edge.jpg)
    * *SQL query filtering messages by receiver:*
        ![SQL Query](https://raw.githubusercontent.com/NabiCook/CIS-School-Work/main/CIS411%20-%20Web%20Application%20Development/program_screenshots/2025-04-26%2022_48_32-SQLQuery1.sql%20-%20cis411database.database.windows.net.CIS411%20(cis411bd%20(87))_%20-%20Mi.jpg)

* **Sent Messages Folder:** Users can view a list of all messages they have sent. This was implemented by filtering messages by the `sender` field.
    ![Sent messages view](https://raw.githubusercontent.com/NabiCook/CIS-School-Work/main/CIS411%20-%20Web%20Application%20Development/program_screenshots/2025-04-23%2021_33_49-Messages%20-%20CIS411Project%20and%2078%20more%20pages%20-%20Personal%20-%20Microsoft_%20Edge.jpg)

* **Message Deletion:** Users can delete messages from their Inbox or Sent folder. An `HTTP GET` request handles the deletion, and the user is redirected back to the appropriate page.

[**Browse the code for this project here.**](https://github.com/NabiCook/CIS-School-Work/tree/main/CIS411%20-%20Web%20Application%20Development)

---

### CIS 481: Cybersecurity Labtainers

This course involved hands-on labs using Labtainers, a framework for cybersecurity exercises. These labs demonstrated my ability to work with network filters and understand system privileges.

* **net-filter Lab:** This lab focused on configuring network firewalls. A key task was creating rules to allow or block specific traffic, such as allowing only SSH connections from a designated IP address.
    ```bash
    # Example: A rule to allow inbound SSH from a specific source
    sudo ufw allow from 192.168.0.10 to any port 22 proto tcp
    ```

* **priv-execute Lab:** This lab explored program execution privileges and vulnerabilities. I analyzed how programs can be exploited when running with elevated permissions and identified insecure coding practices.
    ```c
    // Example of a vulnerable C code snippet that might be exploited
    // Using strcpy without checking buffer size can lead to a buffer overflow.
    void vulnerable_function(char *input) {
        char buffer[100];
        strcpy(buffer, input); // Vulnerable line
    }
    ```

[**See more from this course here.**](https://github.com/NabiCook/CIS-School-Work/tree/main/CIS%20481)

---

### CIS 310: C# and ASP.NET

This course focused on object-oriented programming using C# and the ASP.NET framework. The assignments below showcase my ability to work with Windows Forms, data structures, and file I/O.

* **Assignment 3 (A3):** Implemented custom data validation and exception handling in a Windows Forms application.
    ```csharp
    // Example: Using a try-catch block for robust input parsing
    try
    {
        int quantity = int.Parse(quantityTextBox.Text);
        // ... process valid input
    }
    catch (FormatException)
    {
        MessageBox.Show("Please enter a valid number for quantity.");
    }
    ```
* **Assignment 8 (A8):** Developed a program to perform file I/O operations, including reading from and writing to text files to persist application data.
* **Assignment 10 (A10):** Utilized LINQ (Language Integrated Query) to efficiently query in-memory collections and simplify data manipulation.

[**Browse the assignments for this course here.**](https://github.com/NabiCook/CIS-School-Work/tree/main/CIS310)

---

### CIS 200: Business Application Development

This project involved creating a multi-form Windows application to capture user input, process it, and save the data to an XML file.

* **Step 1: Data Entry Form**
    ![Input Form](https://raw.githubusercontent.com/NabiCook/CIS-School-Work/main/img/program3-1.png)

* **Step 2: Success Confirmation**
    ![Success Form](https://raw.githubusercontent.com/NabiCook/CIS-School-Work/main/img/program3-2.png)

* **Step 3: Saved XML Output**
    ![XML Output](https://raw.githubusercontent.com/NabiCook/CIS-School-Work/main/img/program3-3.png)

[**See the code for this project here.**](https://github.com/NabiCook/CIS-School-Work/tree/main/CIS200/Program3)

---

### CIS 199: Introduction to Programming

This was one of my first projects, built to solve a practical problem using fundamental programming logic in C#. The application calculates shipping costs based on the destination state and package weight.

![Program 1 Interface](https://raw.githubusercontent.com/NabiCook/CIS-School-Work/main/img/program1.png)

[**See the code for this project here.**](https://github.com/NabiCook/CIS-School-Work/tree/main/CIS199/Program%201)