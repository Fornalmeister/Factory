// See https://aka.ms/new-console-template for more information
using Factory;

var shapeFactory = new ShapeFactory();

var circle = shapeFactory.CreateShape(ShapeType.Circle);
circle.Render();

var triangle = shapeFactory.CreateShape(ShapeType.Triangle);
triangle.Render();

var rectangle = shapeFactory.CreateShape(ShapeType.Rectangle);
rectangle.Render();