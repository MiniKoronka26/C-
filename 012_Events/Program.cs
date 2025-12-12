// Подія - це механізм,
// який дозволяє об'єктам повідомляти інші об'єкти про те,
// що щось сталося.

// Подія - це ситуація, при виникненні якої виконується дія або декілька дій.

// Видавець - це об'єкт, який оголошує подію.
// Підписник - це об'єкт, який підписується на подію видавця.


using _012_Events;

Counter counter = new Counter(); // Publisher
Handler1 handler1 = new Handler1(); // Subscriber
Handler2 handler2 = new Handler2(); // Subscriber
Handler3 handler3 = new Handler3(); // Subscriber
counter.eventCount += handler1.Message; // Subscribe for event
counter.eventCount += handler2.Message; // Subscribe for event
counter.eventCount += handler3.Message; // Subscribe for event


counter.Count();














