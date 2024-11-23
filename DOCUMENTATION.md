<h1>MathLibrary</h1>
<h2>This is a math library with a few features/functions</h2>

<h1>Index</h1>
<ul>
    <li> <a href="#m3">Matrix 3</a> </li>
    <li> <a href="#m4">Matrix 4</a> </li>
    <li> <a href="#v2">Vector 2</a> </li>
    <li> <a href="#v3">Vector 3</a> </li>
    <li> <a href="#v4">Vector 4</a> </li>
</ul>

<h2 id="m3">Matrix 3 Class</h2>
<ul>
    <li>Returns Identity matrix</li>
    <li>Provides rotation matrix, allows rotating with a given radian or with x & y coordinates</li>
    <li>Provides operators for addition, subtraction, and multiplying matrices</li>
    <li>Provides operator for multiplying a matrix by a vector3</li>
    <li>Contains a ToString method to convert a matrix into a readable string</li>
    <li>Gives data values for each element in a matrix</li>
</ul>

<h2 id="m4">Matrix 4 Class</h2>
<ul>
    <li>Returns a matrix rotating around its x, y, or z axis</li>
    <li>Operator overloads for multiplying a Matrix4 by a Vector4</li>
    <li>Operator overload for multiplying two Matrix4s</li>
</ul>

<h2 id="v2">Vector 2 Class</h2>
<ul>
    <li>Gives the use of x and y components of a vector</li>
    <li>Provides magnitude function, which returns the length of a vector</li>
    <li>Provides normalize function, which returns a unit vector of the original vector</li>
    <li>Provides DotProduct function, which returns an angle between two vectors</li>
    <li>Provides a function to return the distance between two Vector2s</li>
    <li>Provides a conversion from System.Numerics.Vector2 to MathLibrary.Vector2, and vice versa</li>
</ul>

<h2 id="v3">Vector 3 Class</h2>
<ul>
    <li>gives use of x, y, and z components of a vector</li>
    <li>Provides magnitude function for returning the length of a vector</li>
    <li>Provides normalize function for the unit length of a vector</li>
    <li>Provides DotProduct function to give the angle between two vectors</li>
    <li>Provides an operator for adding two vectors</li>
    <li>Provides an operator for subtracting two vectors</li>
    <li>Provides an operator for multiplying a vector by a scalar</li>
    <li>Provides an operator for dividing a vector by a scalar</li>
    <li>Converts from System.Numerics.Vector3 to MathLibrary.Vector3</li>
</ul>

<h2 id="v4">Vector 4 Class</h2>
<ul>
    <li>Provides x, y, z, and w components of a vector</li>
    <li>Provides a function for calculating the magnitude of a 4D vector</li>
    <li>Provides normalization to return a unit vector</li>
    <li>Provides a function to calculate the dot product of two vectors</li>
    <li>Supports operator overloads for vector addtion, subtraction, and scalar multiplication</li>
</ul>