
// Line 1: When creating a switch statement you will always need to start with the switch keyword. After that inside of the parenthesis you add in the value that you are testing.

// Line 2: Here we use the case keyword followed by a choice that the expression in parenthesis above could be.

// Line 3: If the expression matches the case here the code will run.

// Line 4: The break keyword is added here so that if the case is met it will break out of the switch case and move on instead of checking the other cases below.

// Line 5: We have another case here. You can add in as many as needed in a switch statement.

// Line 8: Similar to ending an else if statement with else, the default code block will be run if none of the cases above match.

switch(expression) {
    case x:
      // code block
      break;
    case y:
      // code block
      break;
    default:
      // code block
    }

    let ingredients = "Salmon"

    switch (ingredients) {
      case "Ground Beef":
        console.log("I'll make Hamburgers.")
        break;
      case "Salmon":
        console.log("I'll make grilled Salmon.")
        break;
      case "Chicken":
        console.log("I'll make Chicken Tacos.")
        break;
      default:
        console.log("I guess I should order something")
    }
    
    let answer = "B";

if (answer === "A" || answer ==="B") {
  console.log("Gryffindor")
} else if (answer === "C" || answer ==="D"){
  console.log("Hufflepuff")
} else if (answer === "E" || answer ==="F"){
  console.log("Ravenclaw")
} else if (answer === "G" || answer ==="H"){
  console.log("Slytherin")
} else {
  console.log("Must be a Muggle.")
}

let answer = "B"

switch (answer) {
  case "A":
  case "B":
    console.log("Gryffindor")
    break;
  case "C":
  case "D":
    console.log("Hufflepuff")
    break;
  case "E":
  case "F":
    console.log("Ravenclaw")
    break;
  case "G":
  case "H":
    console.log("Slytherin")
    break;
  default:
    console.log("Must be a Muggle.")
}