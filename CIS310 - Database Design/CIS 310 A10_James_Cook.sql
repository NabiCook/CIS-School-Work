--===========================================================================
--============================= CIS310 ASSIGNMENT 10 =========================
--===========================================================================

/*
STUDENT NAME: James Cook   
STUDENT ID: 5441819
SUBMISSION DATE: 04/21/2024


For each of the following business request PROVIDE THE SQL Query that adequtely performs the tasks.
**These queries are based on STAYWELL DB Tables and their data contents**

Grading:
Proper Code Formatting is 20% of homework grade
Executable code can earn up to 100% of the grade
Unexecutable code can only earn up to a max of 50% of the grade
*/


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



-- 2. Create a Stored Procedure UPDATE_OWNER_YOURFIRSTNAMELASTNAME (E.G. UPDATE_OWNER_JIAOWANG), and its corresponding execution/test code.
--This Stored Procedure takes 2 parameters/variables:  
--I_OWNER_NUM to store user input value of a OWNER_NUM, and I_LAST_NAME to store user input value of a new LAST_NAME. 
--This stored procedure should update/change the last name to the given value, for the given owner num.	


CREATE PROCEDURE UPDATE_OWNER_JAMESCOOK 
    @I_OWNER_NUM CHAR(5), 
    @I_LAST_NAME VARCHAR(20)
AS 
BEGIN
    UPDATE OWNER
    SET LAST_NAME = @I_LAST_NAME
    WHERE OWNER_NUM = @I_OWNER_NUM
END;
