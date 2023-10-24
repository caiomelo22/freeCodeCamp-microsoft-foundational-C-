string permission = "Admin|Manager";
int level = 55;

string message;
if (permission.Contains("Admin"))
{
    string positionName = level > 55 ? "Super Admin" : "Admin";
    message = $"Welcome, {positionName} user";
}
else if (permission.Contains("Manager") && level >= 20)
{
    message = "Contact an Admin for access.";
}
else
{
    message = "You do not have sufficient privileges.";
}

Console.WriteLine(message);