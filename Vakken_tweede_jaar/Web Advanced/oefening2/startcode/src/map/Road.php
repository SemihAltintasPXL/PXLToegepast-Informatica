<?php
namespace map;
//require_once 'src/map/Point.php';

class Road{
    private array $array_points;

    private function __construct(){
        $this->array_points = [];
    }
    static function make(){
        return new self();
        //return self::class;
        //return new Road();
    }
    public function addPoint(Point $point){
        array_push($this->array_points, $point);
    }
    public function manhattanDistance(){
        $som = 0;
        foreach ($this->array_points as $point){
            $som += $point->manhattanDistance();
        }
        return $som;
    }
}

