<?php

namespace App\Repository;


use App\Data\CategoryDTO;

interface CategoryRepositoryInterface
{
    /**
     * @return \Generator|CategoryDTO[]
     */
    public function findAll() : \Generator;
    
    public function findOne(int $id) : CategoryDTO;
    
}