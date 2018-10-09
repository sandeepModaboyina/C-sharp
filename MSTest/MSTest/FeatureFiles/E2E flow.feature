Feature: Verify cart is empty for user logout with items in basket



@E2E

Scenario: Verify cart is empty for user logout with items in basket
Given user create a new account 
Then Login sucessfully  
When adds the most expensive dress and add it to the cart 
And  Log out 
And Login again 
Then ensuring the dress is not in the cart 

