//If you are trying to use a member of a variable that might be null, use the nullconditional operator ?
// instead of throwing an exception, null is assigned to y
int? y = authorName?.Length;

/*
Sometimes you want to either assign a variable to a result or use an alternative value,
such as 3, if the variable is null. You do this using the null-coalescing operator, ??,
as shown in the following code:
*/
// result will be 3 if authorName?.Length is null
var result = authorName?.Length ?? 3;
Console.WriteLine(result);