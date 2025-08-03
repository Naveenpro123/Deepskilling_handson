import React from 'react';

export function OddPlayers({ players: [first, third, fifth] }) {
  return (
    <div>
      <h3>Odd Players</h3>
      <ul>
        <li>First : {first}</li>
        <li>Third : {third}</li>
        <li>Fifth : {fifth}</li>
      </ul>
    </div>
  );
}


export function EvenPlayers({ players: [second, fourth, sixth] }) {
  return (
    <div>
      <h3>Even Players</h3>
      <ul>
        <li>Second : {second}</li>
        <li>Fourth : {fourth}</li>
        <li>Sixth : {sixth}</li>
      </ul>
    </div>
  );
}

function IndianPlayers() {
  const allPlayers = ['Sachin1', 'Dhoni2', 'Virat3', 'Rohit4', 'Yuvraj5', 'Raina6'];

  // Extract using index
  const oddPlayers = allPlayers.filter((_, i) => i % 2 === 0);   
  const evenPlayers = allPlayers.filter((_, i) => i % 2 !== 0);  

  // Merge two arrays
  const T20Players = ['First Player', 'Second Player', 'Third Player'];
  const RanjiTrophyPlayers = ['Fourth Player', 'Fifth Player', 'Sixth Player'];
  const IndianPlayersMerged = [...T20Players, ...RanjiTrophyPlayers];

  return (
    <div style={{ padding: '20px' }}>
      
          <OddPlayers players = { oddPlayers } />
          <EvenPlayers players = { evenPlayers } />

      <h3>List of Indian Players Merged:</h3>
      <ul>
        {IndianPlayersMerged.map((p, i) => (
          <li key={i}>Mr. {p}</li>
        ))}
      </ul>
    </div>
  );
}

export default IndianPlayers;
