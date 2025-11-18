# in-class-activities
## Devlogs
### W1
HelloWorld!

### W2
because the scale of r,g,b is 0-1.0, it includes decimals, so it needs float to accoplish change of colors like from 0 to 0.7.

because the _bounce variable records times of ball that bounced, so we use int.

i should add f after the float number when i calculate on float variable, and remember add ; after finished write one line code.

### W3
tables 9 i think the parameter(input) is int whihch is about your currentfriendship level to datermine wether level achieved required level to make friend tell their secret, and return type(output) is a string to output friend's secret, friend's secret should fromed by text so its string.

### W4
line5 is to set a value of new float variable _movespeed to 1.0f;
line 22 is calling an algorithm achieve the change of value of translation;
line 25 is calling a new method and update new value of translation to transform method which represent object's current location to change it current location and make it move.

### W5
question: Can we make the movement curvy while we transform vectors?
answer: Yes, but to achieve curvy movement we need to use more extended code. transform() only achieve straight movement.
for example, using bezier to create more point object required to achieve while they are moving.

plan: Deer has component of NavMeshAgent use to find way in terrain, use Getcomponent<> to set NavmeshAgent to NevMeshAgent agent variable so that i can use it on Start() then use agent.Setdesintation to set a destination for deer which is transform target variable set his position to Deer's destination to make it move towards to the cat.

### W6
link: https://docs.google.com/document/d/1I9v9DLgH_h1Npt-SvcE6Rrcdn8rclMwmf5H-zmU4f14/edit?tab=t.0
Unity engine
Editor – Week 1 In class activity
Platform 
Build =>(activity#1,How to build for Web and submit on Itch.io)
Scene 
2d/3d
camera
GameObjects – Explained a bit in Week 1 in class activity
Components
Navmesh =>(activity #5, minigame#5)(week 5)
Transform
Animator
Hierarchy 
Collider – Week 4 Slides
Script
Terrian =>(Week 5)

plan: the class need one float _speed as speed of bat
and a transform _playerPosition as player current position.
the class neede Update()method to make bat move toward player gradually, and chase class to start chase and a stop class to stop the chase
chase class to start provide players location to make them move on Update()class
Update class to move towards player
stop class to stop provide location and stop chase
### W7
https://docs.google.com/document/d/1pVQF8OAxJPUS-FvcqORq1R6zN29-Wx7oRm__EkzzC70/edit?usp=sharing

working on environment and basic simple game idea.

step2: on the step two, using the code transform.position += movement * Vector3.forward * _moveSpeed * Time.deltaTime; is incorrect because the direction wont change while muskrat rotate they always use global direciton of xyz so no matter how you rotate muskrat only move in one direction which is global x direction.
so you have to change Vector3.forward to transform.forward change it to muskrat's local direction so that it can change move direction while muskrat rotate, muskrat will always walk forward to where it facing.

### W8
https://docs.google.com/document/d/16E7MYeKCIkKJmTZuHvnYLj52NwDItoDtaQSqPY_kFnM/edit?usp=sharing

worked on UI and plan
## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 