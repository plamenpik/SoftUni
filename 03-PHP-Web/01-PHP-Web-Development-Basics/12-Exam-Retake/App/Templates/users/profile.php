<?php /** @var \App\DTO\UserDTO $data */ ?>

<h1>Hello, <?= $data->getFullName() ?></h1>
<a href="add_item.php">Add new item</a> | <a href="logout.php">logout</a> <br /> <br />
<a href="my_items.php">My Items</a> <br/>
<a href="all_items.php">All Items</a> <br/>