# 0x01. Unity - Unity Concepts  
Files - Descriptions  

0x01-unity_concepts/Assets/Scenes/0-floor.unity - Create a new 3D Unity project called 0x01-unity_concepts. Save your new scene as 0-floor. Create a new Cube GameObject named Floor with the following Transform properties:  

0x01-unity_concepts/Assets/Scenes/1-ball.unity - Duplicate 0-floor by selecting the scene in the Project window and either Edit > Duplicate from the Toolbar or CTRL / CMD + D. Rename the scene 1-ball and open it. Create a new Sphere GameObject named Ball with the following Transform properties:  

0x01-unity_concepts/Assets/Scenes/2-colors.unity, 0x01-unity_concepts/Assets/Materials/floor.mat, 0x01-unity_concepts/Assets/Materials/ball.mat - Duplicate 1-ball, rename it 2-colors, and open it. Create a Materials folder in the Project window, then create a new material named floor. In the Inspector window, change the Albedo color to any color you like using the color picker. Assign the material to the Floor GameObject.

Create a second new material named ball. Change the material color and assign the new material to the Ball GameObject.  

0x01-unity_concepts/Assets/Scenes/3-gravity.unity, 0x01-unity_concepts/Assets/Physic Materials/bounce - Duplicate 2-colors, rename it 3-gravity, and open it. Add a Rigidbody Component to the Ball GameObject. Press Play to see what happens. Wouldn’t it be better if the ball bounced when it fell?

Create a new folder in the Project window named Physic Materials and create a new Physic Material called bounce. Feel free to edit the material’s settings to get an idea of what the different settings affect. Add the bounce material to the Ball’s Sphere Collider. Press Play. For this task, your final bounce material settings should be:  

0x01-unity_concepts/Assets/Scenes/4-prefab.unity, 0x01-unity_concepts/Assets/Prefabs/Ball - Duplicate 3-gravity, rename it 4-prefab, and open it. Create a new folder named Prefabs. Create a prefab from the Ball inside the new folder, then, using the prefab, add four more instance of the Ball to the scene. Position and scale them any way you like.  

0x01-unity_concepts/Assets/Scenes/5-more_colors.unity, 0x01-unity_concepts/Assets/Materials/ball-* - Duplicate 4-prefab, rename it 5-more_colors, and open it. Change the colors of each ball so they are different hex colors as defined below. New materials should be named as listed below. You cannot use scripts in this task.  

0x01-unity_concepts/Assets/Scenes/6-tags.unity, 0x01-unity_concepts/Assets/Prefabs/Ball.prefab - Duplicate 5-more_colors, rename it 6-tags, and open it. Add a tag to all Ball objects called Obstacles.  
