import React, {FC} from 'react'
import { Route, Routes } from 'react-router-dom'

import { DashboardPage, LoginPage, NotFoundPage } from '../pages'

const AppRoutes = () => {
  return (
    <Routes>
      <Route path='/' element={<LoginPage />} />
      <Route path='/dashboard' element={<DashboardPage />} />
      <Route path='*' element={<NotFoundPage />} />
    </Routes>
  )
  
}

export default AppRoutes