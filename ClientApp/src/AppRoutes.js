import { Counter } from "./components/Counter";
import { FetchData } from "./components/FetchData";
import { Home } from "./components/Home";
import { HomePage } from "../src/pages/homePage"
import { Reserva } from '../src/pages/reserva'

const AppRoutes = [
  {
    index: true,
    element: <Home />
  },
  {
    path: '/homePage',
    element: <HomePage />
  },
  {
    path: '/reserva',
    element: <Reserva />
  }
];

export default AppRoutes;
