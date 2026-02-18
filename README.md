# C-Advanced-Exam-SoftUni
# C-Advanced-Exam-SoftUni

---

## 1. Energy Drinks

### Problem Description

On the first line, you will receive a sequence of numbers representing milligrams of caffeinе.
On the second line, you will receive another sequence of numbers representing energy drinks.

It is important to know that the maximum caffeine Stamat can have for the night is **300 milligrams**, and his initial is always **0**.

To calculate the caffeine in the drink take the **last milligrams of caffeinе** and the **first energy drink**, and multiply them. Then, compare the result with the caffeine Stamat drank:

* If the sum of the caffeine in the drink and the caffeine that Stamat drank doesn't exceed 300 milligrams:

  * Remove both the milligrams of caffeinе and the drink from their sequences.
  * Add the caffeine to Stamat's total caffeine.
* If Stamat is about to exceed his maximum caffeine per night:

  * Do not add the caffeine to Stamat’s total caffeine.
  * Remove the milligrams of caffeinе.
  * Move the drink to the end of the sequence.
  * Reduce the current caffeine that Stamat has taken by 30.

    > **Note:** Stamat's caffeine cannot go below 0.

Stop calculating when you are out of drinks or milligrams of caffeine.

For more clarification, see the examples below.

---

### Input

* First line – sequence of milligrams of caffeinе

  * Integers separated by `", "`
  * Range: `[1, 50]`
* Second line – sequence of energy drinks

  * Integers separated by `", "`
  * Range: `[1, 300]`

---

### Output

**First line:**

* If Stamat hasn't drunk all the energy drinks:

  ```
  Drinks left: { remaining drinks separated by ", " }
  ```
* If Stamat has drunk all the energy drinks:

  ```
  At least Stamat wasn't exceeding the maximum caffeine.
  ```

**Second line:**

```
Stamat is going to sleep with { current caffeine } mg caffeine.
```

---

### Constraints

* You will always have at least one element in each sequence at the beginning.

---

---

## 2. Rally Racing

### Problem Description

On the first line, you will be given an integer **N**, which represents the size of a square matrix.
On the second line you will receive the racing number of the tracked race car.

On the next **N lines** you will be given the rows of the matrix (string sequences, separated by whitespace), representing the race route.

The tracked race car always starts with coordinates `[0, 0]`.

There will be a tunnel somewhere across the race route. If the race car runs into the tunnel, the car goes through it and exits at the other end.

* There will always be two positions marked with `"T"` (tunnel).
* The finish line will be marked with `"F"`.
* All other positions will be marked with `"."`.

---

### Movement Rules

Keep track of the kilometers passed.

* Every time the race car moves to the next position → **10 kilometers**
* If the car goes through the tunnel → **30 kilometers**

After the matrix input, you will receive directions:

* `left`
* `right`
* `up`
* `down`

The race car starts moving across the race route:

* If you receive `"End"` before reaching the finish line:

  ```
  Racing car {racing number} DNF.
  ```
* If the car steps on `"."`:

  * Passes 10 km
  * Waits for next direction
* If the car steps on `"T"`:

  * Goes through the tunnel
  * Moves to the other `"T"`
  * Passes 30 km
  * Both `"T"` positions become `"."`
* If the car reaches `"F"`:

  * The race is over
  * Print:

    ```
    Racing car {racing number} finished the stage!
    ```
  * The car covers another 10 km for the last move

---

### Input

* First line – `N` (size of square matrix)
* Second line – racing number
* Next `N` lines – race route (space-separated elements)
* Following lines – directions (`left`, `right`, `up`, `down`)
* Last line – `"End"`

---

### Output

* If the racing car reaches `"F"` before `"End"`:

  ```
  Racing car {racing number} finished the stage!
  ```
* If `"End"` is given before reaching `"F"`:

  ```
  Racing car {racing number} DNF.
  ```

**Second line:**

```
Distance covered {kilometers passed} km.
```

At the end:

* Mark the last known position with `"C"`
* Print the final state of the matrix
* Row elements should **NOT** be separated by whitespace

---

### Constraints

* Directions will always lead to valid coordinates in the matrix.
* There will always be two `"T"` positions.
* Matrix size: `[4…10]`

---

---

## 3. Computer Architecture

### Problem Description

Your task is to create a computer repository that stores CPU components by creating the classes described below.

---

## CPU (Central Processing Unit)

Create a class `CPU` with the following properties:

* `Brand` – string
* `Cores` – int
* `Frequency` – double

### Constructor

Receives:

* brand
* cores
* frequency

### Override `ToString()`

Format:

```
{brand} CPU:
Cores: {cores}
Frequency: {frequency} GHz
```

> Format the frequency to **one digit after the decimal point**.

---

## Computer

Create a class `Computer` with a multiprocessor (collection of `CPU`).

All entities inside the collection have the same fields.

Each computer has motherboard capacity, limiting how many CPUs can be added.

### Properties

* `Model` – string
* `Capacity` – int
* `Multiprocessor` – `List<CPU>`

### Constructor

Receives:

* model
* capacity

Initializes the multiprocessor collection.

---

### Functionality

* `Count` (getter)
  → Returns number of CPUs

* `Add(CPU cpu)`
  → Adds CPU if there is room
  → If not, skip

* `Remove(string brand)`
  → Removes CPU by brand
  → Returns `true` if removed, otherwise `false`

* `MostPowerful()`
  → Returns CPU with highest frequency

* `GetCPU(string brand)`
  → Returns CPU by brand
  → If not found → return `null`

* `Report()`
  → Returns string:

```
CPUs in the Computer {model}:
{CPU1}
{CPU2}
...
```

---

### Constraints

* Computer models are always unique.
* Capacity is always positive.
* CPU brands are always unique.
* CPU cores are positive.
* CPU frequency is positive.
* There will always be CPUs added before manipulating the Computer's multiprocessor.
