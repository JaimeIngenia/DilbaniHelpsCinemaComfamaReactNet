import "bootstrap/dist/css/bootstrap.min.css"
import { useState, useEffect } from "react";
import {
  createBrowserRouter,
  Router,
  RouterProvider,
} from "react-router-dom";
import  HomePage  from "../src/pages/homePage"
import  Reserva  from '../src/pages/reserva'
import Tareas from "./components/tareas/Tareas";
import Footer from "../src/components/footer/Footer"
import Header from "../src/components/header/Header"
import React from "react";



const router = createBrowserRouter([
    {
        path: '/',
        element: <HomePage />
      },
      {
        path: '/reserva',
        element: <Reserva />
      },
      {
        path: '/tareas',
        element: <Tareas />
      }
]);

const App = () => {

    return (

        <>
                <Header/>
                <RouterProvider router={router} />   
                <Footer />
        </>
           

    )
}

export default App;