# Sensor.Mantratec React Conversion

This folder contains the React.js conversion workspace for the full Sensor.Mantratec front-end route surface.

## Included in this conversion

- React 19.2.0 + React Router 7 app scaffold.
- Route mapping for all current MVC action routes found in:
  - `SiteController`
  - `ProductsController`
  - `SupportController`
  - `BlogController`
- A React page shell for every mapped route so the full project route surface is represented in React.

## Run locally

```bash
npm install
npm run dev
```

## Build

```bash
npm run build
```

## Next migration steps

1. Move each Razor view's page content into route-specific React components.
2. Replace legacy server-rendered partials with React shared layout components.
3. Configure ASP.NET MVC to serve the built React assets for production.
