# CIS Coursework Portfolio
This repository showcases some of my course works from CIS classes. They demonstrate my ability to program in C# and SQL, as well as understanding in database design.

---

## Featured Projects

### CIS 411: Web Application Development - MVC Web Messaging App

This was a semester-long group project to build a web application based on .NET MVC. Microsoft Azure database server was used as a backend to store and handle SQL queries.

**Key Features Implemented:**

* **Account Access:** The messaging menu is only visible to authenticated users. The top navigation bar dynamically changes based on the user's login status. This was implemented with a modification on the LoginPartial with IsSignedIn(User) condition.


	* *Logged Out View (No messaging options)*
		![Logged out view](https://raw.githubusercontent.com/NabiCook/CIS-School-Work/main/CIS411%20-%20Web%20Application%20Development/program_screenshots/2025-04-23%2021_33_33-Home%20Page%20-%20CIS411Project%20and%2078%20more%20pages%20-%20Personal%20-%20Microsoft_%20Edge.jpg)

	* *Logged In View (Showing messaging options)*
		![Logged in view](https://raw.githubusercontent.com/NabiCook/CIS-School-Work/main/CIS411%20-%20Web%20Application%20Development/program_screenshots/2025-04-23%2021_33_17-Home%20Page%20-%20CIS411Project%20and%2078%20more%20pages%20-%20Personal%20-%20Microsoft_%20Edge.jpg)


```html
<ul class="navbar-nav">
	@if (SignInManager.IsSignedIn(User))
	{
		<li class="nav-item">
			<a class="nav-link text-dark" asp-area="" asp-controller="Home" asp-action="Inbox">Inbox</a>
		</li>
		<li class="nav-item">
			<a class="nav-link text-dark" asp-area="" asp-controller="Home" asp-action="Sent">Sent</a>
		</li>
		<li class="nav-item">
			<a  class="nav-link text-dark" asp-area="Identity" asp-page="/Account/Manage/Index" title="Manage">Hello @User.Identity?.Name!</a>
		</li>
		<li class="nav-item">
			<form  class="form-inline" asp-area="Identity" asp-page="/Account/Logout" asp-route-returnUrl="@Url.Action("Index", "Home", new { area = "" })">
				<button  type="submit" class="nav-link btn btn-link text-dark">Logout</button>
			</form>
		</li>
	}
	else
	{
		<li class="nav-item">
			<a class="nav-link text-dark" asp-area="Identity" asp-page="/Account/Register">Register</a>
		</li>
		<li class="nav-item">
			<a class="nav-link text-dark" asp-area="Identity" asp-page="/Account/Login">Login</a>
		</li>
	}
</ul>
```


* **Private Inbox:** Each user can only view messages sent directly to them. This was achieved by adding a `receiver` field to the database and filtering messages based on the currently logged-in user.
	* *Users can only see messages where they are the recipient:*
		![Inbox view](https://raw.githubusercontent.com/NabiCook/CIS-School-Work/main/CIS411%20-%20Web%20Application%20Development/program_screenshots/2025-04-23%2021_33_44-Messages%20-%20CIS411Project%20and%2078%20more%20pages%20-%20Personal%20-%20Microsoft_%20Edge.jpg)
	* *SQL database structure:*
		![SQL Query](https://raw.githubusercontent.com/NabiCook/CIS-School-Work/main/CIS411%20-%20Web%20Application%20Development/program_screenshots/2025-04-26%2022_48_32-SQLQuery1.sql%20-%20cis411database.database.windows.net.CIS411%20(cis411bd%20(87))_%20-%20Mi.jpg)
###### the following logic handles filtering
`if (message.MessageReceiver == HttpContext.User.Identity.Name.ToLower())
{
	userMessage.Add(message);
}`

* **Sent Messages Folder:** Users can view a list of all messages they have sent. This was implemented by filtering messages by the `sender` field.
	![Sent messages view](https://raw.githubusercontent.com/NabiCook/CIS-School-Work/main/CIS411%20-%20Web%20Application%20Development/program_screenshots/2025-04-23%2021_33_49-Messages%20-%20CIS411Project%20and%2078%20more%20pages%20-%20Personal%20-%20Microsoft_%20Edge.jpg)

* **Message Deletion:** Users can delete messages from their Inbox or Sent folder. An `HTTP GET` request handles the deletion, and the user is redirected back to the appropriate page.

```html
[HttpGet]
public async Task<IActionResult> DeleteSent(int id)
{
	MessageDBContext db = new MessageDBContext();
	var deleteMessage = await db.Message.FindAsync(id);
	db.Message.Remove(deleteMessage);
	await db.SaveChangesAsync();
	return RedirectToAction("Sent");
}

```

[**Browse the code for this project here.**](https://github.com/NabiCook/CIS-School-Work/tree/main/CIS411%20-%20Web%20Application%20Development)

---


### CIS 310: Database Design

This course focused on object-oriented programming using C# and the ASP.NET framework. The assignments below showcase my ability to work with Windows Forms, data structures, and file I/O.

* **Assignment 3 (A3):** Used Microsoft Visio to design an Entity Relationship Diagram (ERD).
![ERD](https://raw.githubusercontent.com/NabiCook/CIS-School-Work/main/CIS310%20-%20Database%20Design/A3%20Drawing.png)

* **Assignment 8 (A8):** Developed a program to perform file I/O operations, including reading from and writing to text files to persist application data.
```sql
--2. 	For every service request for 'Furniture Replacement', list the property ID, 
--management office number, address, estimated hours, spent hours, owner number, 
--and owner’s last name.

SELECT S.PROPERTY_ID, P.OFFICE_NUM, P.ADDRESS, S.EST_HOURS, S.SPENT_HOURS, P.OWNER_NUM, (SELECT LAST_NAME FROM OWNER WHERE P.OWNER_NUM = OWNER.OWNER_NUM) AS LNAME
FROM SERVICE_REQUEST S INNER JOIN PROPERTY P ON S.PROPERTY_ID = P.PROPERTY_ID
WHERE CATEGORY_NUMBER LIKE (
SELECT CATEGORY_NUM 
FROM SERVICE_CATEGORY
WHERE CATEGORY_DESCRIPTION LIKE 'Furniture Replacement');
```
* **Assignment 10 (A10):** Utilized LINQ (Language Integrated Query) to efficiently query in-memory collections and simplify data manipulation.
```sql
-- 1. Create a Stored Procedure DISPLAY_OWNER_YOURFIRSTNAMELASTNAME (E.G. DISPLAY_OWNER_JIAOWANG), and its corresponding execution/test code.
--This Stored Procedure takes a single parameter/variable named INPUT_PROPERTY_ID to store user input value of a PROPERTY_ID. 
--It should output OFFICE_NUM, ADDRESS, OWNER_NUM and OWNER_NAME (concatenated FirstName LastName in proper format) 
--from the PROPERTY and OWNER tables for the given PROPERTY_ID
CREATE PROCEDURE DISPLAY_OWNER_JAMESCOOK 
	@INPUT_PROPERTY_ID SMALLINT
AS 
BEGIN
	SELECT P.OFFICE_NUM, P.ADDRESS, O.OWNER_NUM, CONCAT(O.FIRST_NAME, ' ', O.LAST_NAME) AS OWNER_NAME
	FROM PROPERTY AS P 
	JOIN OWNER AS O ON P.OWNER_NUM = O.OWNER_NUM
	WHERE P.PROPERTY_ID = @INPUT_PROPERTY_ID
END;

```
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