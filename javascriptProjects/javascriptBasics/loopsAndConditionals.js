// ! OBJECTS
// * JAVASCRIPT IS AN OBJECT ORIENTED PROGRAMMING (OOP) LANGUAGE.
/*
    Anything in the "STACK" (value types) Immutable, and any thing on the "Heap"
    (reference types [like objects/arrays]) are mutable (can be changed).
*/ 

const student = {
    // comma separated key: 'value', pairs to build out structure of object
    name: "Cassandra",
    age: 21,
    status: "stressed",
    gpa: 4.0,
    passing: true,
}

//* changing object property values/ adding new properties in object.
//changing properties (DOES allow different data types to be assigned to the property)

student.name = "Jordan"

// add properties
student.grade = "Post grad"

// ! DESTRUCTING AN OBJECT IN JS
let {name, age, status} = student

console.log (`This is ${student.name}. They are ${student.age} yeasts old and are ${student.status}`)

// * SQUARE BRACKET NOTATION IN OBJECT
console.log ('This student is in ${student["grade"]}`)


// ! ARRAYS 
// values are accessed through the INDEX (starts at 0) of the value in the array.
const arrEx = ["Nick","Othella", 23, true, {name: "TJ", age: 100}]

// using JSON.stringify() to represent full object and properties as a string
console.log(`arrEx[4] : ${JSON.stringify(arrEx[4].)}`)

const students = ["Jordan", "Fez", "Carly", "Buford", "Bulwinkle", "Freddy"]
// students.length = 6

// * basic "for" loop
// "for" loops in the context of ARRAYS iterator should always start at 0
/*
    1 = declaration of "iterator" variable
    2 = "limit" for how long loop should run for
    3 = how much iterator should be increased/decreased after each instance
    4 = body of code to be executed for each instance
*/

//      1           2               3
for(let i = 0; i < students.length ; i++) {
    // 4
    console.log(`Hello ${students[i]}`)
}


// * "for... of" loop for arrays

for (let student of students) {
    console.log(`Wat you want ${student}`)
}


// * ".forEach()" loop for arrays

students.forEach((student) => {
    console.log(`This is the forEach ${student}`)
})

// * ".map()" loop for arrays
// RETURNS NEW ARRAY BASED ON .map() CALLBACK FUNCTION
const newStudents = students.map((student) => student + " person")

console.log(newStudents)


// ! LOOPING OVER OBJECTS
const student = {
    name: "Cassandra",
    age: 21,
    status: "stressed",
    gpa: 4.0,
    passing: true,
}

// * "for... in" loop (IN FOR OBJECTS!!!)

for (const key in student) {
    console.log(`${key} : ${student[key]}`)
}


// ! CONDITIONALS

const isHungry = false
const age = 14

/*
    IF/ELSE CONDITIONAL RULES:
    - only have ONE "if" AND ONE "else" statement in if/else block
    - "else/if" statements are only allowed directly after an if statement
    - "else" AND "else/if" statements are not required to be functional
*/

if (isHungry) {
    console.log("Eat something goofy!")
} else if (isHungry && age >= 21) {
    console.log("let's get some food at Brothers in Bripp!")
} else if (isHungry && age < 21) {
    console.log("Go to Chuck E Cheese youngin")
} else {
    // only use if all other conditions have been exhausted
    console.log("read a book or something")
}


// * TERNARY STATEMENTS
// <conditional> ? <true-code> : <false-code>

age >= 21 ? console.log("Lets party!") : console.log("go to school")


// * SWITCH CASES
// allows you to execute sections of code based on the VALUE of the variable being passed in to the "switch case"

let character = "Jim"

switch (character) {
    case "Dwight":
        console.log("has your company been through fire safety protocol?")

        // "breaks" us out of the switch statement after a "case" has been met
        break;
    case "Jim":
        console.log("I don't like this job")

        break;
    case "Stan":
        console.log("I got some nice curly hair")

        break;
    case "Ryan":
        console.log("I'm the temp but I should be running this place")
        break;
    default:
        // basically like an "else" statement
        console.log("Idk you bro")
}