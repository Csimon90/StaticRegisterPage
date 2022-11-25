//1
if (condition1) {
    //  code to be executed if condition1 is true
  //2
  } else if (condition2) {
    //  code to be executed if the condition1 is false and condition2 is true
  //3
  } else {
    //  code to be executed if the condition1 is false and condition2 is false
  }

  let character = 'Wizard'; 

  if (character === 'Bard') {
    console.log('You sing nice songs.')
  } else if (character === 'Warrior') {
    console.log('You beat things up.')
  } else if (character === 'Rogue'){
    console.log('You use stealth.')
  } else if (character === 'Wizard'){
    console.log('You use magic.')
  } else {
    console.log('What type of character is this??')
  }
  let temp = 85;

if (temp >= 80){
  console.log('It is hot.')
} else if (temp >= 65){
  console.log('It is warm.')
} else if (temp >= 50) {
  console.log('It is cool.')
} else {
  console.log('It is cold.')
}