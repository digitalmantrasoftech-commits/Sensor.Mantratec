import { Navigate, Route, Routes } from 'react-router-dom';
import { allPages } from './pages';
import { AppLayout } from './components/AppLayout';
import { ConvertedPage } from './components/ConvertedPage';

export default function App() {
  return (
    <Routes>
      <Route element={<AppLayout />}>
        <Route index element={<Navigate to="/site/index" replace />} />
        {allPages.map((page) => (
          <Route
            key={page.path}
            path={page.path.slice(1)}
            element={<ConvertedPage page={page} />}
          />
        ))}
      </Route>
    </Routes>
  );
}
