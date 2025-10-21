# in-class-activities
## Devlogs
### W1
Hello world!

### W2
Create future Devlog sub-headers with the three # symbols, then write your Devlogs below them.

1. The r, g, and b variables are floats instead of ints, bools or
strings because rgb values can only go from 0.0 - 1.0.

2. The "_bounce" variable is an int instead of a float, bool, or string
because each point added is by one which is a whole number and ints store
whole numbers.

3. I didn't get the error because I fixed it immediately. The error occurs
because the original commented line of code was missing a semi-colon at 
the end.

### W3

Parameters: int friendshipLevel because we need to check if
the character's level is high enough to know the character's
secret.
Return type: bool KnowsSecret because either the player knows
the character's secret or not (true or false)

Table 10

1. Classes are used to implement/create components. Classes are 
like the ingredients of a plate. For example, classes can be the 
egg, or cake batter, and the component is the cake.

2. We think the balls get extremely bright if they bounce
too much because each time they bounce the ball color multiplier
is applied making the values higher and in turn making the color
brighter.

### W4

Table #10

In line 5, a member float variable named "_moveSpeed" is being 
created to store a value of 1 and it can be edited inside the 
inspector because of  [SerializeField].

In line 22, the method GetAxis is being called and being multiplied
to the "_moveSpeed" member variable and the deltaTime member variable,
and the result is being stored in a float variable named translation.

In line 25, the Translation method is being called on a transform object.

1. I added a Capsule Collider to the Cat object and adjusted it based on
it's size. I also added Rigidbodies to the Cat object, the SoccerBall object,
and the goal object. I checked Is Trigger for the Cat and SoccerBall while I
left Is Trigger unchecked for the Goal object.

2. My Cat object was making the world flip out while it was walking
in the world. I fixed this by freezing the X and Z axis positions
in it's Rigidbody and checking Is Trigger on it.

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 