import { useState } from 'react';
import './App.css';
function CurrencyConvertor() {
    const [amount, setAmount] = useState('');
    const [currency, setcurrency] = useState('');
    const handlesubmit = (e) => {
        e.preventDefault();
        const euro = parseFloat(amount) / 90;
        alert(`Converting to Euro, amount is \u20AC${euro.toFixed(2)}`);
    }


    return (
        <div className="currency">
            <h1>Currency Convertor!!!</h1>
            <form onSubmit={handlesubmit}>
                <label>Amount <input type="number" value={amount} onChange={(e)=>setAmount(e.target.value) } /></label>
            
            <br />
            <label>Currency:</label>
            <input
                type="text"
                    value={currency}
                    onChange={(e) => setcurrency(e.target.value)}
            />
            <br />
            <button type="submit">Submit</button>
        </form>
    </div >
  );
   
}
export default CurrencyConvertor;
