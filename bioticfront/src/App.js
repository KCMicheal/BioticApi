import logo from './logo.svg';
import './App.css';
import { store } from  './Actions/Store';
import { Provider } from 'react-redux';
import BioticUsers from './Components/BioticUsers';


function App() {
  return (
      <Provider store={store}>
        <BioticUsers/>
      </Provider>
  );
}

export default App;
