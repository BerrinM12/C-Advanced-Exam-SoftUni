# C-Advanced-Exam-SoftUni
1.	Energy Drinks

On the first line, you will receive a sequence of numbers representing milligrams of caffeinе. On the second line, you will receive another sequence of numbers representing energy drinks. It is important to know that the maximum caffeine Stamat can have for the night is 300 milligrams, and his initial is always 0.

To calculate the caffeine in the drink take the last milligrams of caffeinе and the first energy drink, and multiply them. Then, compare the result with the caffeine Stamat drank:

•	If the sum of the caffeine in the drink and the caffeine that Stamat drank doesn't exceed 300 milligrams, remove both the milligrams of caffeinе and the drink from their sequences. Also, add the caffeine to Stamat's total caffeine.
•	If Stamat is about to exceed his maximum caffeine per night, do not add the caffeine to Stamat’s total caffeine. Remove the milligrams of caffeinе and move the drink to the end of the sequence. Also, reduce the current caffeine that Stamat has taken by 30 (Note: Stamat's caffeine cannot go below 0).
Stop calculating when you are out of drinks or milligrams of caffeine.
For more clarification, see the examples below.

Input

•	In the first line, you will be given a sequence of the milligrams of caffeinе - integers separated by comma and space ", " in the range [1, 50]
•	In the second line, you will be given a sequence of energy drinks - integers separated by comma and space ", " in the range [1, 300]

Output

On the first line:

o	If Stamat hasn't drunk all the energy drinks, print the remaining ones separated by a comma and a space ", ": 
o	"Drinks left: { remaining drinks separated by ", " }"
o	If Stamat has drunk all the energy drinks, print:
o	"At least Stamat wasn't exceeding the maximum caffeine."


On the next line, print:
o	"Stamat is going to sleep with { current caffeine } mg caffeine."

Constraints

You will always have at least one element in each sequence at the beginning.

2. Rally Racing

On the first line, you will be given an integer N, which represents the size of a square matrix. On the second line you will receive the racing number of the tracked race car.

On the next N lines you will be given the rows of  the matrix (string sequences, separated by whitespace), which will be representing the race route. The tracked race car always starts with coordinates [0, 0]. Thеre will be a tunnel somewhere across the race route. If the race car runs into the tunnel , the car goes through it and exits at the other end. There will be always two positions marked with "T"(tunnel). The finish line will be marked with "F". All other positions will be marked with ".".
Keep track of the kilometers passed. Every time the race car receives a direction and moves to the next position of the race route, it covers 10 kilometers. If the car goes through the tunnel, it covers NOT 10, but 30 kilometers.
On each line, after the matrix is given, you will be receiving the directions for the race car.
•	left
•	right
•	up
•	down
The race car starts moving across the race route:
•	If you receive "End" command, before the race car manages to reach the finish line, the car is disqualified and the following output should be printed on the Console: "Racing car {racing number} DNF."
•	If the race car comes across a position marked with ".". The car passes 10 kilometers for the current move and waits for the next direction.
•	If the race car comes across a position marked with "T" this is the tunnel. The race car goes through it and moves to the other position marked with  "T" (the other end of the tunnel). The car passes 30 kilometers for the current move. The tunnel stays behind the car, so the race route is clear, and both the positions marked with "T", should be marked with ".".
•	If the car reaches the finish line - "F" position, the race is over. The tracked race car manages to finish the stage and the following output should be printed on the Console: "Racing car {racing number} finished the stage!". Don’t forget that the car has covered another 10 km with the last move.

Input
•	On the first line you will receive N - the size of the square matrix (race route)
•	On the second line you will receive the racing number of the tracked car
•	On the next N lines, you will receive the race route (elements will be separated by a space).
•	On the following lines, you will receive directions (left, right, up, down).
•	On the last line, you will receive the command "End".

Output
•	If the racing car has reached the finish line before the "End" command is given, print on the Console: "Racing car {racing number} finished the stage!"
•	If the "End"  command is given and the racing car has not reached the finish line yet, the race ends and the following message is printed on the Console: "Racing car {racing number} DNF."
•	On the second line, print the distance that the tracked race car has covered: "Distance covered {kilometers passed} km." 
•	At the end, mark the last known position of the race car with "C" and print the final state of the matrix (race route). If the race car hasn’t gone through the tunnel, the tunnel exits should be visualized in the final state of the matrix. The row elements in the output matrix should NOT be separated by a whitespace.

Constraints
•	The directions will always lead to coordinates in the matrix.
•	There will always be two positions marked with "T" , representing the tunnel in the race route.
•	The size of the square matrix (race route) will be between [4…10].

3. Computer Architecture

Your task is to create a computer repository that stores CPU components by creating the classes described below.

CPU (Central Processing Unit)
You are given a class CPU,  create the following properties:
•	Brand - string
•	Cores - int
•	Frequency - double
The class constructor should receive brand, cores, and frequency.
Override the ToString() method in the following format:
"{brand} CPU:
Cores: {cores}
Frequency: {frequency} GHz"
Note: Format the Frequency to the first digit after the decimal point!

Computer

Next, you are given a class Computer that has a Multiprocessor (a collection that stores CPU entities). All entities inside the collection have the same fields. Every Computer will have Capacity of the motherboard, and adding new CPU will be limited by the Capacity. Also, the Computer class should have the following properties:
•	Model - string
•	Capacity – int 
•	Multiprocessor – List<CPU>
The class constructor should receive the model and capacity, also it should initialize the multiprocessor with a new instance of the collection.
Implement the following features:
•	Getter Count - returns the number of CPUs
•	Method	 Add(CPU cpu) - adds an entity to the multiprocessor if there is room for it. If there is no room for another CPU, skip the command
•	Method Remove(string brand) - removes a CPU by a given brand. If such exists, returns true, otherwise, returns false.
•	Method MostPowerful() - returns the most powerful CPU (the CPU with the highest frequency)
•	Method GetCPU(string brand) – returns the CPU with the given brand. If there is no CPU, meeting the requirements, return null
•	Method Report() - returns a String in the following format:	
o	"CPUs in the Computer {model}:
{CPU1}
{CPU2}
(…)"

Constraints
•	The models of the computers will be always unique.
•	The capacity of the computer will always be with positive values.
•	The brand of the CPUs will be always unique.
•	The cores of the CPUs will always be with positive values.
•	The frequency of the CPUs will always be with positive values.
•	You will always have a CPUs added before receiving methods manipulating the Computer's multiprocessor.
