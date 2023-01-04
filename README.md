# IA_FSM

Working with Fine State Machines in Unity. 

Creating four different States for the Robot: Attack, Patrol, Chase and Hide.

The robot will move between 4 waypoints in Patrol State, and will start chasing the player if distance is less than 40.

![ANM1](https://user-images.githubusercontent.com/114673717/210632503-eb9e3367-b8f4-4c66-9ab6-d1f3175825cb.gif)

Also, is distance is less than 20 the Robot will start Attack State. But if distance is greater than 20 the Robot will enter state Chase.

![ANM2](https://user-images.githubusercontent.com/114673717/210632682-5195a2c8-dcdb-489c-9721-48058a496d9f.gif)

Finally, when health is below 40 the robot will enter state Hide, and if hp is greater than 40 will enter Patrol state again.




