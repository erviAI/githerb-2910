# Outline

Extend existing and add new functionallity to `githerb`

## Herbs

* `Extend /herbs endpoint with pageing and filtering`

  ```
  Add pageing and filter on name property, default pagesize=5
  ```
  *optional add sorting*

* `Extend the herb type with new properties`

  *Description (required)*
  ```
  Can you please add description property?
  ```
  
  *Spiciness (optional)*
  ```
  Can you also add a spice or spiciness property?
  ```
  *Add more herbs*
  ```
  Add X more herbs to the list in HerbsSeeder
  ```
  *in C# show difference inline vs chat*

## Basket
* `Create basket`
  ```
  Create a new BasketOfHerbs. Its Id should be the maximum id + 1. Add it to the repository
  ```

* `Add herbs to the basket`
  ```
  Can you add herbs with the give herbId to the basket of basketId? 
  ```
  
## Test 

* `validity of basket`
  ```
  Add more tests to cover all the rules #file:BasketOfHerbs
  ```
  
* `naming convention`
  ```
  Use the following naming convention: MethodName_StateUnderTest_ExpectedBehavior
  ```

## Documentation

* `Generate documentation`
  
  ```
  Can you document the endpoint code so its available in swagger?
  ```
