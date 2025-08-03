function ListofPlayers() {

    const players = [
        { name: 'Jack', score: 50 },
        { name: 'Michael', score: 70 },
        { name: 'John', score: 40 },
        { name: 'Ann', score: 61 },
        { name: 'Elisabeth', score: 61 },
        { name: 'Sachin', score: 95 },
        { name: 'Dhoni', score: 100 },
        { name: 'Virat', score: 84 },
        { name: 'Jadeja', score: 64 },
        { name: 'Raina', score: 75 },
        { name: 'Rohit', score: 80 },
    ];

    let players70 = [];
    players.map((items) => { if (items.score < 70) { players70.push(items); } });
    return (
        <div>
            <h2>List of Players</h2>
            <ul>
                {players.map((player, index) => (<li key={index}>Mr {player.name} {player.score} </li> )) }



            </ul>

            <h2>Players with score less than 70</h2>
            <ul>
                {players70.map((player, index) => (<li key={index}>Mr {player.name} {player.score} </li>))}
             </ul>



        </div>
    
    
    );

}
export default ListofPlayers;
