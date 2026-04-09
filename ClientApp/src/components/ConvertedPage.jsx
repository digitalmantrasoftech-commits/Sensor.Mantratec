export function ConvertedPage({ page }) {
  return (
    <article className="page-card">
      <header>
        <p className="badge">{page.section}</p>
        <h1>{page.title}</h1>
      </header>
      <p>
        This route has been migrated into the React application shell.
      </p>
      <dl>
        <dt>React Route</dt>
        <dd>{page.path}</dd>
        <dt>Legacy MVC Route</dt>
        <dd>{page.legacyRoute}</dd>
      </dl>
      <p>
        Next step: move page-specific UI/content from the legacy Razor view into a dedicated React component.
      </p>
    </article>
  );
}
