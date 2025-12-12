using _012_PingPongEvents;

PingPongEventArgs pingPongEventArgs = new PingPongEventArgs();
Ping ping = new Ping();     
Pong pong = new Pong();
ping.pingPongEvent += pong.Ping;
pong.pingPongEvent += ping.Pong;
ping.Pong(pong, pingPongEventArgs);