<?php
    $mysqli = mysqli_init();
    $mysqli->ssl_set(NULL, NULL, "/etc/ssl/certs/ca-certificates.crt", NULL, NULL);
    $mysqli->real_connect("aws.connect.psdb.cloud","6asg08z32zcp6ccqxkll","pscale_pw_fuFYI0w5RzvLeZCQN2vq21X4VX1LpxvLYnSFBjDSN0u","sosar");
   
    echo "Connected to MySQL<br>"
?>