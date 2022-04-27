<?php
namespace map;

use http\Exception\InvalidArgumentException;

class Point{
    private $x;
    private $y;

    private function __construct($x, $y){
        if ($x > 0 && $x < 100 && $y > 0 && $y < 100){
            $this->x = $x;
            $this->y = $y;
        }
        else{
            throw new \InvalidArgumentException("x and or y needs to be between 0 - 100");
        }
    }
    public static function make($x, $y){
        return new self($x, $y);
    }
    public function manhattanDistance(Point $point){
        return abs( $this->x - $point->x) + abs($this->y - $point->y);
    }
}


