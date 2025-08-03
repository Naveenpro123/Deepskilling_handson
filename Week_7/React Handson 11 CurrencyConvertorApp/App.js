import { useState } from "react";
import './App.css'; 
import CurrencyConvertor from "./CurrencyConvertor";

function App() {
    const [count, setCount] = useState(0);
    const sayHello = () => {
        alert("Hello!");
    };

    const staticMessage = () => {
        alert("This is a static message");
    };
    const increment = () => {
        if (count === 0) {
            sayHello();
            staticMessage();
        }
        setCount(count + 1);
        
    }
    const decrement = () => {
        setCount(count - 1);
    }
    
    return (
        <div className="App">
            <h1>{count}</h1>
            <br/>
            <button onClick={increment}>Increment</button><br />
            <button onClick={decrement}>Decrement</button><br />
            <button onClick={() => { return alert("Welcome!") }}> Say Welcome</button><br />
            <button onClick={() => { return alert("I was clicked") }}> Click on me</button><br />
            <CurrencyConvertor />
        </div>
    );

}
export default App;
