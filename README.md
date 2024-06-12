# WindowsApp7

Pennies for Pay
Iterative Example

Susan is hired for a job, and her employer agrees to pay her every day. Her employer also agrees that Susan's salary is one penny the first day, two pennis the second day, four pennies the third day, and continuing to double each day.

Create an application that allows the user to enter the number of days that Susan will work and calculates the total amount of pay she will receive over the period of time.

Inputs:

Days:

Output:

Total Amount:

###################################################################
Get Days

dblSalary =.01
dblTotalPay = 0
intCOunter = 1

Do until intCounterc > Days
	dblTotalPay += dblSalary
	dblSalary = dbl * 2
	intCounter += 1
Loop
####################################################################
