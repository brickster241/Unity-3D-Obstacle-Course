
# Unity 3D : Obstacle Course

- Focuses on Basics of Unity Engine
- Obstacles such as spinners, droppers, walls, etc.
- Covers fundamentals of **C# programming** and concepts of **Unity** components - **Materials, Assets, Scripts, Prefabs**, etc.

### How to Play 
- Use arrow keys to avoid obstacles.
- If you collide with an obstacle, it will turn red.
- Your goal is to reach from one end to the other end.

**NOTE**: If your players passes through the obstacles, reduce the speed in **`ObjectHit.cs`** script and try it again.

### Some of the Unity Concepts which you will learn
- **`Methods`** : 
    - **`Start()`** : Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
    - **`Update()`** : Update is called every frame, if the MonoBehaviour is enabled. Update is the most commonly used function to implement any kind of game script. 
    - **`OnCollisionEnter(Collision other)`** : OnCollisionEnter is called when this collider/rigidbody has begun touching another rigidbody/collider. 
    - **`gameObject`** : GameObjects are the fundamental objects in Unity that represent characters, props and scenery. 
    - **`Time.deltaTime`** : Time. deltatime is the time that has passed to complete the last frame. Used to make speed frame independent.
    - **`Input.GetAxis(string axisName)`** : Returns the value of the virtual axis identified by axisName.
- **`MeshRenderer`** : The Mesh Renderer takes the geometry from the Mesh Filter and renders it at the position defined by the object's Transform component. 
- **`RigidBody`** : Rigidbodies are components that allow a GameObject to react to real-time physics. This includes reactions to forces and gravity, mass, drag and momentum.
- **`SerializeField`** : Serialization is the automatic process of transforming data structures or object states into a format that Unity can store and reconstruct later. 

