for ([initialExpression]; [conditionExpression]; [incrementExpression]){
    //For loop body (code to be executed each loop)
    }

//[initialExpression] sets the starting value of a
//    loop control variable (LCV).  
// [conditionExpression] is evaluated, if true, 
//     stay in the loop, otherwise exit the loop. 
// [incrementExpression] updates the LCV.

console.log(1);
console.log(2);
console.log(3);
console.log(4);
console.log(5);...console.log(100);
/* 
Infinite Loop
Something to know before you start working with loops is that it is possible to create an infinite loop accidentally. If this happens and your code will not stop running:
Press ctrl + c to stop the code from executing. If this does not work close VS code and open it again.
*/

/*Practice: Write a for loop:
going from  0 to 50 by 5s.
going from 20 to 1 by -1s.
starting at 3, and increments by 5, but doesn't go over 30.




Answers
Loop from  0 to 50 by 5s.

for(let i = 0; i <= 50; i += 5){
    console.log(i);
}
Loop from 20 to 1 by -1s.

for (let i = 20; i >= 1; i--){
    console.log(i);
}
Loop starting at 3, and increments by 5, but doesn't go over 30.

for(let i = 3; i < 30; i += 5){
    console.log(i)
}
More Practice
Write 10 loops. Challenge yourself. This is the way to learn. Here are a couple starter ideas:

Count to 200 by 25s. Start at 25.
Count to 10 by 2s. Start at 6.
Count to 10 by 5s. Start at 100.
Practice until you can write a for loop without looking at examples. */