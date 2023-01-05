# IA_FSM

Fine State Machine (FSM) in Unity.

In this project the main task is to create a Fine State Machine for the NPC (Robot) and add 4 different States. The states will be *Patrol, Attack, Chase and Hide*. 

First let's place some waypoints in the scene for the Patrol state, so the robot will move between them. Second, when the distance between the Player and the Robot is less than 40, the NPC will start chasing the Player until distance between them is again greater than 40.

![ANM1](https://user-images.githubusercontent.com/114673717/210632503-eb9e3367-b8f4-4c66-9ab6-d1f3175825cb.gif)

Also, is distance is less than 20 the Robot will start Attack State. But if distance is greater than 20 the Robot will enter state Chase.

![ANM2](https://user-images.githubusercontent.com/114673717/210632682-5195a2c8-dcdb-489c-9721-48058a496d9f.gif)

Finally, when Robot health is low it will enter the state Hide and run away from the player.

