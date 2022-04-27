<?php

//use map\Road;

require_once 'src/map/Point.php';
require_once 'src/map/Road.php';

$road=Road::make();
$point1=Point::make(1,2);
$road->addPoint($point1);
$point2=Point::make(3,4);
$road->addPoint($point2);
print($point1->manhattanDistance($point2));
print("\n");
print($road->manhattanDistance());
print("\n");

