import React, {FC} from 'react';
import {BrowserRouter} from 'react-router-dom'

//Routes
import AppRoutes from './Routes/AppRoutes';

const App: FC<any> = () => {
  return (
    <BrowserRouter>
      <AppRoutes />
    </BrowserRouter>
    
  );
}

export default App;
