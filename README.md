# Palindromes

# Solution 1

This solution is the first one I came up with. It takes into account subpalindromes from one palindrome, because the UNIQUE word had been understood as "different strings".
This solution doesn't perform very good. 

# Solution 2

This solution is the second I did in order to improve the first one. This solution doesn't take into account subpalindromes from one palindrome, because the UNIQUE word has been understood as "do not use subpalindromes from one 
found palindrome".
This solution performs better than the first one.

# Architecture

The solution consists of three projects: 

	- Console App: The execution of this app demonstrates how the second solution improves the first one in terms of performance.
	- Service: When the palindromes backend logic happens. This project is referenced in the other two.
	- Tests: Unit tests for both solutions using xUnit.




 
