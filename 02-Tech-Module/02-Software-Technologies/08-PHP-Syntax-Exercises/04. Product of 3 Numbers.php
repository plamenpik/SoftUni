<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
    <form>
        X: <input type="text" name="num1" />
		Y: <input type="text" name="num2" />
        Z: <input type="text" name="num3" />
		<input type="submit" />
    </form>
	<!--Write your PHP Script here-->
    <?php
    if (isset($_GET['num1']) && ($_GET['num2']) && ($_GET['num3'])) {
        $n = intval($_GET['num1']);
        $m = intval($_GET['num2']);
        $k = intval($_GET['num3']);
        $sum = $n * $m *$k;
        if ($sum >= 0) {
            echo 'Positive';
        } else {
            echo 'Negative';
        }
    }
    ?>
</body>
</html>