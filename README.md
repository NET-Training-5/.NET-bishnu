# Git Essentials

Git Repo
- Remote - Github
- Local  - On our laptop

You make changes (Add, modify, delete)
-- One time operation, for the first time
``` 
> git config user.email "Github email"
> git config user.name "Your user name"
```
```
> git add .
> git commit -m "Sensible commit message which describes your changes"
> git push (For the first time, git may welcome you with authorization popup)
```

## Create new console application
```
>dotnet new console -n Fundamentals
>cd Fundamentals
>dotnet build/run
```

# Assignments
1. Create a real world class with following:
    1. 4 fields: 2 public, 1 internal and a privte
    1. Two methods
    1. Create two objects of this class in another class/method and assin values for above fields for each object.
1. Print following pattern in console:
    ```
    #
    ##
    ###
    ####
    #####
    ```
    ```
    1
    22
    333
    4444
    55555
    666666

    ```

1. Write a method to find min and max of supplied numbers. This method should also accept variable number of arguments.

1. Think of a real world class with following:
    1. Two fields
    1. Two properties: one autoimplemented, one write-only
    1. A method which prints details of objects of that class

1. Think of a real world scnario for following:
    ``` 
        TypeB inherits TypeA
        TypeB implements InterfaceA
    ```
    1. Note that **TypeA** should have at least two methods, two fields and two properties.
    1. Create instance of **TypeB**, show output of those methods in console.
1. Create an array containing 20 country names. Query this collection to answer following:
    1. List all countries starting with letter N.
    1. List all countries which have length of 4 or less.
    1. Convert all countries to uppercase.

1. Read vegetables data from *Kalimati.csv* and parse that to ***List<Vegetable>*** collection.
    1. Find all vegetables with average price less than Rs. 10 and save it to a text file.
    1. Find all vegetables traded on 6/17/2013 with minimum price of at least 40 and save it to a text file.

1. Create a web page containing a form to input employee details. Apply bootstrap style to all form elements.
