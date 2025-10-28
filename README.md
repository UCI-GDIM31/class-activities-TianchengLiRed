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

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 