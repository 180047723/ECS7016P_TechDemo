# **ECS7016P_TechDemo**



Welcome to my tech demo !
First Time building a Unity3D Project :) 
Enjoy !

![image](https://user-images.githubusercontent.com/104271448/165012878-e3919987-d420-4c69-8f94-74750fcb195b.png)


Video Link: https://www.youtube.com/watch?v=xDA5jfo7tg4



### HOW TO SET UP
-------------------------------------------------------------
* The project was built using Unity Version 2020.3
* Prefabs folder contains all the game objects + materials. 
* Dowload the files. 
* Open the files using Unity3D (Version 2020.3)
* Inside the Scenes folder (Assets > Scenes > TechDemoScene) press the Techdemo.unity file.  
* Press play and this will run the generator and agents (as shown above).
* This will also show the different game objects in the hierarchy window as shown below. 

![image](https://user-images.githubusercontent.com/104271448/165041652-aa4ca4b2-5398-41f4-baed-60023587cd2b.png)


### AIM OF PROJECT
-------------------------------------------------------------
* This project was built for ECS7016P Interactive Agents and Procedural Generation module assingment. 
* The aim of the assignmet was to create a level generator and an interactive agent. 
* The generator should use some Procedural Generation (PG) techniques. 
* The agent should use some behaviour and navigation techniques. 

* The aim of the agent is not to fall of the platform and land on the moving terrain. 
* The enemy is in control of shooting randomly at the agent trying to get the agent off the platform. 
* The agent can run and take cover using the walls (Yellow Cubes - as shown above). 
* The terrain generator moves rapidly and is dangerous for the agent if they land on it. 



### LEVEL GENERATOR 
-------------------------------------------------------------

![image](https://user-images.githubusercontent.com/104271448/165025433-295c1c88-5003-406b-8733-08959787eaa6.png)


* The Terrain Generator uses the TerrainGen.cs script located in the Generator folder (Assets > Generator > TerrainGen.cs) .
* The level generator generates random heights and levels using a PG technique called Perlin Noise. This is explained and shown in the TerrainGen.cs script. 
* In the TerrainGen.cs script it uses the dimensions and heights/width of the terrain to create the perlin noise.

Below shows how the inspector window should look like for the terrain:

![image](https://user-images.githubusercontent.com/104271448/165028443-b6e6b90f-7f80-4eaa-9036-1a6c5ddc1715.png)

* The purple platform (plane) should be baked using the AI navigation (Window >AI>Navigation) make sure the plane is static and press bake. 
* This allows the agent to move around the platform. 

![image](https://user-images.githubusercontent.com/104271448/165029722-6c4946d5-506f-485b-bed2-50cb92558f5f.png)




For the plane: 
![image](https://user-images.githubusercontent.com/104271448/165028500-bb158294-78ac-4f4d-9ce6-a26747b674d9.png)





### INTERACTIVE AGENT
-------------------------------------------------------------

![image](https://user-images.githubusercontent.com/104271448/165027243-4fa0e37f-7684-40ef-9073-8a3b2ae63d08.png) ---> Agent

* The Agent (Green Capsule) uses the AgentMove.cs script located in the Agent folder (Assets > Agent > AgentMove.cs). 
* The Agent uses the Wandering and Cover, Navigation Behaviour techniques to move and hide from the enemy. 
* In the AgentMove.cs script the agent uses different waypoints to move around. This should be added into the Inspector Window in Unity. 


* MAKE SURE YOU CHANGE THE SPEED FOR THE AGENT AS ITS SET TO 0 (The agent will not move). INCREASE THE SPEED SO THAT THE AGENT CAN MOVE AROUND (change in Inspector Window). 
* MAKE SURE YOU ADD THE Waypoints in the inspector tab under the AgentMove.cs script. 


Below shows how the inspector window should look like for the agent:

![image](https://user-images.githubusercontent.com/104271448/165028271-091e7d2c-6cf7-4c20-a257-04f9e56bf46d.png)

![image](https://user-images.githubusercontent.com/104271448/165028306-a6412c7e-b87f-479a-a9be-f5c4e2beac8a.png)


![image](https://user-images.githubusercontent.com/104271448/165027303-0d1c4e5b-14a3-4d45-9d1b-a6b41f81ebf4.png) ---> Enemy

* The Enemy (Red Capsule) uses the AdvancedEnemy.cs script located in the Agent folder (Assets > Agent > AdvancedEnemy.cs). 
* The Enemy uses the shooting and rotate behaviour techniques to attack the agent. 
* The AdvancedEnemy.cs script explains the code. 

* MAKE SURE YOU ASSIGN THE ENEMY AGENT(Enemy), GREEN AGENT(Agent) AND SHOOT (bullets) IN THE INSPECTOR WINDOW UNDER Advanced Enemy (Script). 

Below shows how the inspector window should look like for the enemy:
![image](https://user-images.githubusercontent.com/104271448/165029524-52c520e4-16e7-4b8a-b5ef-e72645c61e9b.png)
![image](https://user-images.githubusercontent.com/104271448/165047190-70182792-b05f-45cd-8abd-3bb32cd36579.png)


### PROJECT IMPROVEMENTS
-------------------------------------------------------------
* Implemented some different techniques to the generator like Wave Function Collapse (WFC) or Evolutionary algorithm. 
* The movement of the agent could be advanced using Behaviour Trees or A* algorithm. 
* Could have used some THIRD-PARTY Assets.


### REFERENCES (Tutorials to help build generator and agent) 
-------------------------------------------------------------

Terrain Generator + Perlin noise: 

* https://www.youtube.com/watch?v=IKB1hWWedMk
* https://www.youtube.com/c/SebastianLague
* https://www.youtube.com/user/brackeys


Agent + Navigation + Behaviours: 

* https://www.youtube.com/c/CodeMonkeyUnity  
* https://www.youtube.com/c/KeySmashStudios/videos
* https://www.youtube.com/channel/UCIWlCE2kt0RXCJLRp8HjhiQ
* https://www.youtube.com/channel/UC5NStd0QmACnWs9DzqJ3vHg




