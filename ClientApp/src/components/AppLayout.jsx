import { NavLink, Outlet } from 'react-router-dom';
import { groupedPages } from '../pages';

export function AppLayout() {
  return (
    <div className="app-shell">
      <aside className="sidebar">
        <h1>Sensor Mantratec</h1>
        <p className="subtitle">React migration workspace</p>
        {Object.entries(groupedPages).map(([section, pages]) => (
          <section key={section} className="section-block">
            <h2>{section}</h2>
            <ul>
              {pages.map((page) => (
                <li key={page.path}>
                  <NavLink to={page.path} className={({ isActive }) => (isActive ? 'active' : '')}>
                    {page.title}
                  </NavLink>
                </li>
              ))}
            </ul>
          </section>
        ))}
      </aside>
      <main className="content">
        <Outlet />
      </main>
    </div>
  );
}
